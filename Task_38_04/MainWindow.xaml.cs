using System.Collections.ObjectModel;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_38_04
{
    // Создайте окно для ввода информации о студенте (отдельно фамилия, имя , отчество, группа,
    // пол – перечисление,дата рождения(календарь))
    // При нажатии на кнопку «сохранить» данные о студенте сохраняются во
    // внутренний список связанный с ListBox
    // При закрытии приложения данные сериализируются в файл

    public enum Gender
    {
        Male,
        Female
    }

    [DataContract]
    public class Student
    {
        [DataMember] public string LastName { get; set; }
        [DataMember] public string FirstName { get; set; }
        [DataMember] public string MiddleName { get; set; }
        [DataMember] public string Group { get; set; }
        [DataMember] public Gender Gender { get; set; }
        [DataMember] public DateTime BirthDate { get; set; }

        public string DisplayName => $"{LastName} {FirstName} {MiddleName}, {Group}";
    }

    public partial class MainWindow : Window
    {
        private ObservableCollection<Student> students = new ObservableCollection<Student>();
        private const string DataFileName = "students.json";

        public MainWindow()
        {
            InitializeComponent();
            LoadStudents();
            lstStudents.ItemsSource = students;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtGroup.Text) ||
                dpBirthDate.SelectedDate == null)
            {
                MessageBox.Show("Заполните обязательные поля: Фамилия, Имя, Группа, Дата рождения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var student = new Student
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                Group = txtGroup.Text,
                Gender = cmbGender.SelectedIndex == 0 ? Gender.Male : Gender.Female,
                BirthDate = dpBirthDate.SelectedDate.Value
            };

            students.Add(student);

            // Очищаем поля ввода
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtGroup.Clear();
            dpBirthDate.SelectedDate = null;
            cmbGender.SelectedIndex = 0;
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstStudents.SelectedItem is Student selectedStudent)
            {
                students.Remove(selectedStudent);
            }
        }

        private void LoadStudents()
        {
            if (File.Exists(DataFileName))
            {
                try
                {
                    using (var stream = File.OpenRead(DataFileName))
                    {
                        var serializer = new DataContractJsonSerializer(typeof(List<Student>));
                        var loadedStudents = (List<Student>)serializer.ReadObject(stream);
                        students = new ObservableCollection<Student>(loadedStudents);
                        lstStudents.ItemsSource = students;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void SaveStudents()
        {
            try
            {
                using (var stream = File.Create(DataFileName))
                {
                    var serializer = new DataContractJsonSerializer(typeof(List<Student>));
                    serializer.WriteObject(stream, new List<Student>(students));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveStudents();
        }
    }
}