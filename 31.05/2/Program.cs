using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1/Запросить у пользователя длину массива
            //2/Создать массив целых чисел
            //3/заполнить их случайными значениями в диапазоне от -50 до 50
            //4/Показать на экран 
            //5/Найти среднее арифметическое данного массива
            //1
            Console.WriteLine("Введите количество элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            //2
            int[] mas = new int[n];
            //3
            Random r = new Random();//переменная для рандома
            for (int i=0;i<n;i++)
            {
                mas[i] = r.Next(-50, 50);
            }

            //4
            for (int i=0;i<n; i++)
            {
                Console.Write(mas[i] + " ");
            }
            //5
            int sum = 0;
            for (int i=0;i<n;i++)
            {
                sum = sum + mas[i];
            }
            double d = 1.0 * sum / n;
            Console.WriteLine("среднее равно" + d);

            Console.ReadKey();
        }
    }
}
