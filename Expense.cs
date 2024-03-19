using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    public class Expense
    {
        public string category {  get; set; }
        public string description {  get; set; }
        public double price { get; set; }
        public DateTime date { get; set; }

        public Expense(string category, string description, double price, DateTime date)
        {
            this.category = category;
            this.description = description;
            this.price = price;
            this.date = date;
        }
    }
}
