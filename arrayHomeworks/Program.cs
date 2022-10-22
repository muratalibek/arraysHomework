using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayHomeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое число для установки размера массива");

                int size;
                int evenIndex = 0;
                int arrayMinValue = int.MaxValue;

                try
                {
                    size = int.Parse(Console.ReadLine());
                    Console.WriteLine("Массив состоит из " + size + " количества индексов!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы не ввели целое число!");    
                    Console.ReadLine();
                    continue;
                }
                int[] arrayOne = new int[size];

                try
                {
                    for (int i = 0; i < arrayOne.Length; i++)
                    {
                        arrayOne[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы не ввели достаточное количество целых чисел!");
                    Console.ReadLine();
                    continue;
                }

                for (int i = 0; i < arrayOne.Length; i++)
                {
                    Console.Write(arrayOne[i] + " ");
                    
                }
                Console.WriteLine();

                Console.WriteLine("Данный массив в обратном порядке: ");
                for (int i = arrayOne.Length-1; i >= 0; i--)
                {
                    
                    Console.Write(arrayOne[i] + " ");
                }

                Console.WriteLine() ;

                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i]%2 == 0)
                    {
                        evenIndex += arrayOne[i]; // 
                    }
                }
                Console.WriteLine("Сумма четных чисел в массиве:" + evenIndex);

                /*for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i] < arrayOne[i+1])
                    {
                        arrayOne[i+1] = arrayOne[i];
                        arrayMinValue = arrayOne[i+1];
                    }
                }
                Console.WriteLine("Минимальное число в массиве: " + arrayMinValue);*/
                Console.ReadLine();
            }
        }
    }
}
