using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_09
{
    internal class Ticket
    {
        public decimal Price { get; set; }
        public bool HasLuggage { get; set; }
        public bool IsDiscount { get; set; }

        public override string ToString()
        {
            return $"Цена: {Price}, Багаж: {HasLuggage}, Льготный: {IsDiscount}";
        }
    }
}
