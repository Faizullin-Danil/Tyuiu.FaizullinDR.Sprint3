using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint3.Task2.V21.Lib;


namespace Tyuiu.FaizullinDR.Sprint3.Task2.V21
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
            Console.WriteLine("* Задание #2                                                                           *");
            Console.WriteLine("* Вариант #21                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу используя цикл do while, которая вычисляет сумму ряда по формуле, *");
            Console.WriteLine("* при x = 1,5                                                                          *");
            Console.WriteLine("*     10                                                                               *");
            Console.WriteLine("* S = ∑(1/(sin(k)+2*x^k))^k                                                            *");
            Console.WriteLine("*     k=1                                                                              *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            Console.WriteLine("x = 1,5");



            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine(ds.GetSumSeries(1.5));

            Console.ReadLine();
        }
    }
}
