using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.GaleevTS.Sprint5.TaskReview.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\timur_8n182p8\source\repos\Tyuiu.GaleevTS.Sprint5.Review\Tyuiu.GaleevTS.Sprint5.TaskReview.V18\bin\Debug\InPutDataFileTask7V17.txt"
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
