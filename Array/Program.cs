using System;
using Library;

namespace Array
{
    class Program
    {
        /// <summary>
        /// Запрашивает у пользователя размер массива и выводит результат.
        /// </summary>
        /// <param name="args"></param>
    
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            var mass = int.Parse(Console.ReadLine());
            Console.WriteLine(MessageFunction.Array( ref mass));
            GC.Collect();
            Console.WriteLine("Память после сбора мусора: {0}", GC.GetTotalMemory(true));
        }

    }

    /// <summary>
    /// Вызывает метод из библиотеки.
    /// </summary>
    /// <param name="mass"></param>
    /// <returns></returns>
    public struct MessageFunction
    {
        public static string Array( ref int mass)
        {
            try
            {
                LibraryMethods function = new LibraryMethods();
                return function.GetArray( ref mass);
            }
            catch
            {
                return "Введено некорректное значение";
            }
        }
    }

}
