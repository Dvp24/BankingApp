using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApp.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Original_Description { get; set; }
        public string Amount { get; set; }
        public string Transaction_Type { get; set; }
        public string Category { get; set; }
        public string Account_Name { get; set; }
        public string Labels { get; set; }
        public string Notes { get; set; }

    }
}