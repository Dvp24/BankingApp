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

        
    }
}