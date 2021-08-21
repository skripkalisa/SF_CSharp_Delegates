using System;
using System.Collections;


namespace Task1
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                IterateExceptions();
            }
            catch (Exception e)
            {
                Console.WriteLine("Не получилось вывести список исключений: " + e.Message);
            }
        }

        private static void IterateExceptions()
        {
            foreach (var exception in new ExceptionsArray().Exceptions)
            {
                try
                {
                    exception.Data.Add("Дата создания исключения : ", DateTime.Now);
                    throw exception;
                }
                catch (Exception e)
                {
                    foreach (DictionaryEntry en in e.Data)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(en.Key + en.Value?.ToString());
                    }
                }
            }
        }
    }
}