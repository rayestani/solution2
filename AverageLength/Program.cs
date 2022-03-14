using System;
using Library;

namespace AverageLength
{
    class Program
    {
        /// <summary>
        /// Запрашивает у пользователя строку и выводит результат.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            var line = Console.ReadLine();
            string result;
            MessageFunction.Average(ref line, out result);
            Console.WriteLine(result);
            GC.Collect();
            Console.WriteLine("Память после сбора мусора: {0}", GC.GetTotalMemory(true));
        }

        /// <summary>
        /// Вызывает метод из библиотеки
        /// </summary>
        public struct MessageFunction
        {
            public static void Average(ref string line, out string result)
            {
                try
                {
                    LibraryMethods function = new LibraryMethods();
                    result= function.GetAverage( ref line);
                }
                catch
                {
                    result= "Введено некорректное значение";
                }
            }
        }

    }

}
