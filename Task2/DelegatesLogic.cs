using System;

namespace Task2
{
    public class DelegatesLogic
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

                // Проверка ввода числа здорового человека:
                // 
                // var num = Int32.TryParse(Console.ReadLine(), out var key);
                // if (num)
                //     return key;
                // return 0;

                // Проверка ввода числа курильщика:
                // 
                int key = 0;
                try
                {
                    key = Int32.Parse(Console.ReadLine() ?? String.Empty);

                    if (key < 1 || key > 3)
                        throw new CustomException("Нужно ввести 1, 2 или 3");

                }
                catch (CustomException e)
                {
                    Console.WriteLine("CustomException: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                
                return key;
            }
        }
    }
}