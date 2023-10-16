using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint3.Task0.V1.Lib;

namespace Tyuiu.FaizullinDR.Sprint3.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            Console.Title = "Спринт #3 | Выполнил: Файзуллин Д. Р. | ИИПБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                            *");
            Console.WriteLine("* Тема:  алгоритмы циклической структуры                                               *");
            Console.WriteLine("* Задание #0                                                                           *");
            Console.WriteLine("* Вариант #1                                                                           *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по формуле,      *");
            Console.WriteLine("* при x = 4                                                                            *");
            Console.WriteLine("*     15                                                                               *");
            Console.WriteLine("* S = ∑(x^2*i)+1                                                                       *");
            Console.WriteLine("*     i=1                                                                              *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            Console.WriteLine("X = 4");



            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine(ds.GetSumSeries(4));

            Console.ReadLine();
        }
    }
}
