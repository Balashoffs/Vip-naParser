using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            ExportToCSV exportTo = new ExportToCSV();

            var htmlDoc = new HtmlDocument();
            htmlDoc.Load(student.HtmlPath, Encoding.UTF8);

            HtmlNodeCollection nodeCollection = htmlDoc.DocumentNode.SelectNodes(student.ForParsingProperty);
            
            student.FillDictionaryDataFromHtml(nodeCollection);
            
            foreach (var item in student.dictionaryDataFromHtml.Values)
            {
                nodeCollection = htmlDoc.DocumentNode.SelectNodes(item);
                student.ParseDataFromHtml(nodeCollection);
                
            }

            ExportToCSV.ExporToCSV(ExportToCSV.saveToTxt, student.listParsedData);
            Console.ReadKey();

        }  
    }
}
