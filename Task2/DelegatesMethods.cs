using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class DelegatesMethods
    {
        private static List<string> MakeList()
        {
            List<string> lastNames = new List<string>
            {
                "Lennon",
                "McCartney",
                "Harrison",
                "Starr",
                "Martin"
            };
            return lastNames;
        }

        internal static void sl_OnGetInput(object sender, DelegatesLogic.InputEventArgs args)
        {
            SortList(args.Key);
        }

        private static void PrintList(List<string> lastNames)
        {
            foreach (var lastName in lastNames)
            {
                Console.WriteLine(lastName);
            }
        }

        private static void SortList(int num)
        {
            List<string> lastNames = MakeList();
            switch (num)
            {
                case 1:
                    PrintList(lastNames.OrderBy(i => i).ToList());
                    break;
                case 2:
                    PrintList(lastNames.OrderByDescending(i => i).ToList());
                    break;
                case 3:
                    PrintList(lastNames);
                    break;
                default:
                    Console.WriteLine("Неправильно набран номер");
                    break;
            }
        }
    }
}