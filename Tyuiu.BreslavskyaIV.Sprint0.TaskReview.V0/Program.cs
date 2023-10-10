using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BreslavskyaIV.Sprint0.TaskReview.V0.Lib;


namespace Tyuiu.BreslavskyaIV.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #0                                                                *");
            Console.WriteLine("* Тема: SprintRewiew                              *");
            Console.WriteLine("* Задание #Rewiew                                                          *");
            Console.WriteLine("* Вариант #0                                                               *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Найти значение выражения (x+y+z)*5                                       *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("* Введите X:                                                               *");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("* Введите Y:                                                               *");
            var y = int.Parse(Console.ReadLine());
            Console.WriteLine("* Введите Z:                                                               *");
            var z = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("(x + y + z) * 5 = " + DataService.Calc(x, y, z));
            Console.ReadLine();

        }
    }
}
