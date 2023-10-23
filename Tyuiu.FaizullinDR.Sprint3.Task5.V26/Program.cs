using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint3.Task5.V26.Lib;

namespace Tyuiu.FaizullinDR.Sprint3.Task5.V26
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
            Console.WriteLine("* Задание #5                                                                           *");
            Console.WriteLine("* Вариант #26                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("*      3  13                                                                           *");
            Console.WriteLine("*  y = Σ   Σ (x^k + sin(k)) , при X = 2                                                *");
            Console.WriteLine("*     i=1 k=1                                                                          *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 13;
            int x = 2;

            Console.WriteLine("X = " + x);
            Console.WriteLine("Старт шага первой суммы = " + startValue1);
            Console.WriteLine("Стоп шага первой суммы = " + stopValue1);
            Console.WriteLine("Старт шага второй суммы = " + startValue2);
            Console.WriteLine("Стоп шага второй суммы = " + stopValue2);




            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadLine();
        }
    }
}
