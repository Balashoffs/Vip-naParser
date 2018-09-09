using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ConsoleApp1
{
    class Student
    {
        bool isFirst = false;
        string typeOfData = "//td/input"; // типы данных
        public string ForParsingProperty { get { return typeOfData; } }

        string template = "//td[@id='X']"; // шаблон, куда вместо Х буду подставлять тип данных, потом записывать в массив строк
        public string KeysElements { get { return template; } }
        
        public Dictionary<string, string> dictionaryDataFromHtml = new Dictionary<string, string>();
        public List<string> listParsedData = new List<string>();

        string htmlPath = @"d:\myProgects\htmlparservipassana\vipassana\work2018.html";
        public string HtmlPath { get { return htmlPath; } set { htmlPath = value; } }

        public void FillDictionaryDataFromHtml(HtmlNodeCollection htmlNode)
        {
            string tempStr = "";
            foreach (var item in htmlNode)
            {
                tempStr = item.Attributes["name"].Value;
                dictionaryDataFromHtml[tempStr] = template.Replace("X", tempStr);
                Console.WriteLine(tempStr);
                    
            }
            tempStr = "";
            foreach (var item in dictionaryDataFromHtml.Keys)
            {
                tempStr += item + ",";
            }
            listParsedData.Add(tempStr);
            Console.WriteLine(listParsedData[0]);
            
        }

        public void ParseDataFromHtml(HtmlNodeCollection htmlNode)
        {
            string tempStr = "";

            int i = 1;
            if (!isFirst)
            {
                foreach (var item in htmlNode)
                {
                    tempStr = item.InnerText.Trim() + ",";
                    listParsedData.Add(tempStr);
                }
                isFirst = true;
            }
            else
            {
                foreach (var item in htmlNode)
                {
                    if (item.Id == "birth_date")
                    {
                        tempStr = item.InnerText.Trim();
                        tempStr = tempStr.Substring(0, 10);
                        Console.WriteLine(tempStr);
                        tempStr += ",";

                    }
                    else
                    {
                        tempStr = item.InnerText.Trim() + ",";
                    }
                    
                    listParsedData[i] += tempStr;
                    Console.WriteLine(listParsedData[i]);
                    ++i;
                }
                    
            }
                
            


        }





    }
}
