using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class ExportToCSV
    {
        public static string saveToTxt = @"data.csv";

        private const int WIN_1252_CP = 1252;

        public static void ExporToCSV(string pathToSaveFile, List<string> listData)
        {
            using (StreamWriter sw = new StreamWriter(pathToSaveFile, false, Encoding.Unicode))
            {
                foreach (var item in listData)
                {
                    sw.WriteLine(item);
                }
            }
            
        }

      

        
    }
}
