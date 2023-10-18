using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint3.Task3.V21.Lib;

namespace Tyuiu.FaizullinDR.Sprint3.Task3.V21
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
            Console.WriteLine("* Задание #3                                                                           *");
            Console.WriteLine("* Вариант #21                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву e в строке: f3g5ht g4j 34kg4          *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            Console.WriteLine("f3g5ht g4j 34kg4");
            string str = "f3g5ht g4j 34kg4";
            char c = 'e';



            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine(ds.ReplaceNumOnChar(str,c));

            Console.ReadLine();
        }
    }
}
