using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bull_and_cow
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1234;                     //написать рандом для числа****************************
            int[] array = new int[4];     //Создание  маасива для хранения загаданого числа
            int y;
            bool[] boolar = new bool[10]; //создание маасива для всех чисел от 0-9
            y = x;

            for (int i = 0; i < 10; i++)
            {
                boolar[i]= false;     //Присваивание отрицания всем числам от 0-9
            }

            for (int i = 3; i >=0; i--)
            {
                array[i] = y % 10;    //Внесение в массив загадане в массив по числу от 0-3
                boolar[y % 10] = true; //присваивание истины для каждого числа от 0-9
                y /= 10;               //Отсекание последнего числа
            }

            int bull = 0;

            while (bull != 4)    //Цикл проверки числа на быков и коров
            {

                Console.Write("Введите  4-х значное число:");
                int VVod = Convert.ToInt32(Console.ReadLine());

                int yV = VVod;
                bull = 0;
                int cow = 0;

                for (int i = 3; i >= 0; i--)
                {
                    if (array[i] == yV % 10) //проверка нa быков
                    {
                        bull++;
                    }
                    else
                    {
                        if (boolar[yV % 10] == true) //проверка на коров
                        {
                            cow++;
                        }
                    }
                    yV /= 10;
                }
                Console.WriteLine("Bull={0}  Cow={1}", bull, cow);
            }
            Console.WriteLine("YOU WIN!!!");
        }
    }
}
