using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Обьявить массив длинной 15 элементов
            //Заполнить его случайными значениями от 15 до 35
            //Вывести на экран
            //Найти сумму квадратов элементов массива
            //1
            int n = 15;
            int[] mas = new int[n];
            //2
            Random r = new Random();
            for (int i = 0; i < 15; i++)
            {
                mas[i] = r.Next(15, 35);
            }
            //3
            for (int i = 0; i < 15; i++)
            {
                Console.Write(mas[i] + " ");
            }
            
            //4
            double sum = 0;
            for (int i = 0; i < 15; i++)
            {
                sum = sum + Math.Pow(mas[i], 2);
            }
            Console.WriteLine(" sum ");

            Console.ReadKey();
        }
        
    }
}
