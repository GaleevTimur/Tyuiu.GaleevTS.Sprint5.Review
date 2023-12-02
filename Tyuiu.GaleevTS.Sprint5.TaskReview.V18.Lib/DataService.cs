using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text.RegularExpressions;


namespace Tyuiu.GaleevTS.Sprint5.TaskReview.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\timur_8n182p8\source\repos\Tyuiu.GaleevTS.Sprint5.Review\Tyuiu.GaleevTS.Sprint5.TaskReview.V18\bin\Debug\OutPutDataFileTask7V18.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }


            string fileContent = File.ReadAllText(path);

            string modifiedContent = Regex.Replace(fileContent, @"(?i)н", "нн");

            File.WriteAllText(pathSaveFile, modifiedContent);
            return pathSaveFile;
        }
    }
}
