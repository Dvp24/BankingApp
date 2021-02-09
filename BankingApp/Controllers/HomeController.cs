using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using BankingApp.Models;


namespace BankingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            string Filepath = @"C:\Users\Vishal\Desktop\gistfile1.txt";

            List<Transaction> TransactionsList = new List<Transaction>();
            List<string> lines = System.IO.File.ReadAllLines(Filepath).ToList();

            List<string> newlines = Helpers.List_Helper.FindSortRemove(lines);
            newlines.RemoveAt(0);


            foreach (var line in newlines)
            {
                string[] entries = line.Split(',');
                var amt = float.Parse(entries[3]);
                Transaction newTransaction = new Transaction();
                newTransaction.Id = Guid.NewGuid(); ;
                newTransaction.Date = entries[0];
                newTransaction.Description = entries[1];
                newTransaction.Original_Description = entries[2];
                newTransaction.Amount = amt;
                newTransaction.Transaction_Type = entries[4];
                newTransaction.Category = entries[5];
                newTransaction.Account_Name = entries[6];
                newTransaction.Labels = entries[7];
                newTransaction.Notes = entries[8];

                TransactionsList.Add(newTransaction);
            }
            List<Transaction> LargestTransactions = new List<Transaction>();

            LargestTransactions = Helpers.List_Helper.FindLargest(TransactionsList);
            
            List<Transaction> SmallestTransactions = new List<Transaction>();

            SmallestTransactions = Helpers.List_Helper.FindSmallest(TransactionsList);
            var model = new OutputModel();
            {
                model.TransactionList = TransactionsList;
                model.largestTransactions = LargestTransactions;
                model.SmallestTransactions = SmallestTransactions;
            }
            return View(model);
        }
    }
}