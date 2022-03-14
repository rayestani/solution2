using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// Класс содержит:
    /// 1. Метод вычисляющий индекс массы тела.
    /// 2. Метод сортирующий массив из случайных чисел.
    /// 3. Метод вычисляющий среднее количество символов в словах из строки.
    /// </summary>
    public class LibraryMethods
    {

        /// <summary>
        /// Данный метод вычисляет индекс массы тела.
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public string GetBmi( ref double weight, ref double height)
        {

            if(weight<3 || height<0.5)
            {
                throw new ArgumentOutOfRangeException("Введенные знаяения слишком малы");
            }
            string index = "";
            return index+= weight / (height * height);
        }

       /// <summary>
       /// Данный метод сортирует сформированный массив из случайных чисел.
       /// </summary>
       /// <param name="mass"></param>
       /// <returns></returns>
        public string GetArray(ref int mass)
        {
            if (mass<0)
            {
                throw new ArgumentOutOfRangeException("Размер массива не может быть отрицательным");
            }

            var max = int.MinValue;
            var min = int.MaxValue;
            Random rnd = new Random();
            var sizemass = new int[mass];
            for(var i=0; i<mass; i++)
            {
                sizemass[i] = rnd.Next(-5,5);

                if(sizemass[i] > max)
                {
                     max = sizemass[i];
                }

                if (sizemass[i] < min)
                {
                    min = sizemass[i];
                }

            }
            var sort = new StringBuilder();

            for (var i = 0; i < sizemass.Length; i++)
            {
                for (var j = 0; j < sizemass.Length - 1; j++)
                {

                    if (sizemass[j] > sizemass[j + 1])
                    {
                        var temp = sizemass[j];
                        sizemass[j] = sizemass[j + 1];
                        sizemass[j + 1] = temp;
                    }
                }
            }
            for(var i = 0; i < sizemass.Length; i++)
            {
                sort.Append(sizemass[i]+",");
            }

            return sort.ToString();

        }

        /// <summary>
        /// Данный метод  вычисляет среднее количество символов в словах из строки
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public string GetAverage( ref string line)
        {
            if (line =="")
            {
                throw new ArgumentOutOfRangeException("Необходимо заполнить строку");
            }
            string[] str = line.Split(' ');
            var summ= 0;
            for(var i=0; i<str.Length; i++)
            {
                foreach (char w in str[i])
                {
                    if(char.IsLetter(w))
                    {
                        summ++;
                    }
       
                }
                
            }
            return (summ / str.Length).ToString();
        }

    }
}
