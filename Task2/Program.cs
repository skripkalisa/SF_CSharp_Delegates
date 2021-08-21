using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    
    public delegate void GetInput(object sender, InputEventArgs args);

    public class InputEventArgs : EventArgs
    {
        public int Key;
    }
    
    public class SortList
    {
        public event GetInput OnGetInput;

        public void GetNumber()
        {
            InputEventArgs input = new()
            {
                Key = SlOnGetInput()
            };
            OnGetInput?.Invoke(this, input);
        }

        private int SlOnGetInput()
        {
            Console.WriteLine("Укажите порядок сортировки списка");
            Console.WriteLine("1 - в алфавитном порядке; ");
            Console.WriteLine("2 - обратном алфавитном порядке;");
            Console.WriteLine("3 - без сортировки: ");
        
            var num = Int32.TryParse(Console.ReadLine(), out var key);
            if (num)
                return key;
            return 0;
        }
    }
    
    public class Program
    {
        
        static void Main(string[] args)
        {
            
            SortList sl = new SortList();
            sl.OnGetInput += sl_OnGetInput;
            sl.GetNumber();
        }
        
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

        private static void sl_OnGetInput(object sender, InputEventArgs args)
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