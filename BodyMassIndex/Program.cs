using System;
using Library;

namespace BodyMassIndex
{
    class Program
    {
        /// <summary>
        /// Запрашивает у пользователя вес и массу и выводит полученное в функции значение.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите массу тела");
                var weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ваш рост в сантиметрах");
                var height = double.Parse(Console.ReadLine());
                Console.WriteLine(MessageFunction.BMI(ref weight, ref height));
            }
            catch
            {
                Console.WriteLine( "Необходимо ввести корректное значение роста или веса");
            }
            GC.Collect();
            Console.WriteLine("Память после сбора мусора: {0}", GC.GetTotalMemory(true));

        }
    }
    
    /// <summary>
    /// Вызывает метод из библиотеки.
    /// </summary>
    public struct MessageFunction
    {
        public static string BMI( ref double weight, ref double height)
        {
            LibraryMethods function = new LibraryMethods();
            height = height / 100;
            return function.GetBmi(ref weight, ref height);
        }
    }
    
  

}
