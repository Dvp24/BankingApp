using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApp.Helpers
{
    public class List_Helper
    {
        public static List<string> FindSortRemove( List<string> lines)
        {
            List<string> newLines = new List<string>();
            foreach (string line in lines)
            {
                //repeatedLines = lines.FindAll( i => i == line);
                bool exist = newLines.Exists(i => i == line);

                if (exist == false)
                {
                    newLines.Add(line);
                }
            }
            return new List<string>( newLines); 
        }
        public static List<Transaction> FindLargest(List<Transaction> TransactionList)
        {
            List<Transaction> largestTransactions = new List<Transaction>();

            var tr = TransactionList.Max(x => x.Amount);
            foreach(var transaction in TransactionList)
            {
                if(transaction.Amount == tr)
                {
                    largestTransactions.Add(transaction);
                }
            }

            return new List<Transaction>(largestTransactions);
        }
        public static List<Transaction> FindSmallest(List<Transaction> TransactionList)
        {
            List<Transaction> smallestTransactions = new List<Transaction>();

            var tr = TransactionList.Min(x => x.Amount);
            foreach(var transaction in TransactionList)
            {
                if(transaction.Amount == tr)
                {
                    smallestTransactions.Add(transaction);
                }
            }

            return new List<Transaction>(smallestTransactions);
        }

    }
}