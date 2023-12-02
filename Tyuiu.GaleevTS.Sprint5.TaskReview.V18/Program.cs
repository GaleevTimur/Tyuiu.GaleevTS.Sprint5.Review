using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.GaleevTS.Sprint5.TaskReview.V18.Lib;

namespace Tyuiu.GaleevTS.Sprint5.TaskReview.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт №5 | Выполнил: Галеев Т. С. | ИИПб-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("* Задания #Spint Review                                                    *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнил: Галеев Тимур Серикович | ИИПб-23-3                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("****************************************************************************");
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V18.txt";

            Console.WriteLine("Данные в: " + path);
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V18.txt";


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл создан: " + pathSaveFile);
            pathSaveFile = ds.LoadDataAndSave(path);

            Console.ReadKey();
        }
    }
}
