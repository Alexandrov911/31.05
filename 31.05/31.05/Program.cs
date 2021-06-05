using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Масив целых чисел
            int[] mas = new int[10];
            // заполним числами от 1 до 10
            //mas[0] = 1;
            //mas[1] = 2;
            //mas[2] = 3;
            //mas[3] = 4;
            //mas[4] = 5;
            //mas[5] = 6;
            //mas[6] = 7;
            //mas[7] = 8;
            //mas[8] = 9;
            //mas[9] = 10;
            //или
            for(int i=0;i<10; i++)
            {
                mas[i] = i + 1;
            }
            //печать масива на экран
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("№"+i+" "+mas [i]);
            }
          

            //ищем сумму элеметов массива
            int sum = 0;
            for(int i=0; i<10; i++)
            {
                sum = sum = mas[i];
            }
            Console.WriteLine("сумма" + sum);
            Console.ReadKey();
        }
    }
}
