using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    public class Expense
    {
        
        public decimal price { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }

        
        public Expense(string category, string description, decimal price, DateTime date)
        {
            this.category = category;
            this.description = description;
            this.price = price;
            this.date = date;
        }
    }
}
