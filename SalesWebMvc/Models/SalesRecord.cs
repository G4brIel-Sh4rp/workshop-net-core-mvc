using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enuns;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public double Amount { get; private set; }
        public SaleStatus MyProperty { get; private set; }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus myProperty)
        {
            Id = id;
            Date = date;
            Amount = amount;
            MyProperty = myProperty;
        }


    }
}
