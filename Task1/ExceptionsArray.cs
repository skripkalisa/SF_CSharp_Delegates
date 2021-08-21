using System;
using System.Collections;

namespace Task1
{
    internal class ExceptionsArray : IEnumerable
    {
        public readonly Exception[] Exceptions =
            { CustomException, ArgumentException, DivideByZeroException, NotImplementedException, TimeoutException };
        private static TimeoutException TimeoutException  { get; } = new("Время вышло.");
        private static NotImplementedException NotImplementedException { get; } = new("Такой метод не реализован.");
        private static DivideByZeroException DivideByZeroException { get; } = new("Деление на ноль.");
        private static ArgumentException ArgumentException { get; } = new("Неверно задан(ы) аргумент(ы)");
        private static CustomException CustomException { get; } = new("My Custom Exception: Что-то пошло не так.");
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}