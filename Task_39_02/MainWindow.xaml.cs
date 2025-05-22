using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Task_39_02
{
    // Создайте приложение – список покупок. Использовать ListBox.
    // В качестве источника данных использовать не List, а ObservableCollection
    // Функции:
    // • Ввод продуктов
    // • Сохранение списка продуктов в текстовый файл
    // • Использовать стандартные диалоговые окна

    public partial class MainWindow : Window
    {
        private ObservableCollection<string> shoppingList = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            lstItems.ItemsSource = shoppingList;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewItem.Text))
            {
                shoppingList.Add(txtNewItem.Text);
                txtNewItem.Clear();
                txtNewItem.Focus();
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstItems.SelectedItem != null)
            {
                shoppingList.Remove(lstItems.SelectedItem as string);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.DefaultExt = ".txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, shoppingList);
                    MessageBox.Show("Список успешно сохранен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string[] items = File.ReadAllLines(openFileDialog.FileName);
                    shoppingList.Clear();
                    foreach (var item in items)
                    {
                        shoppingList.Add(item);
                    }
                    MessageBox.Show("Список успешно загружен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}