using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Log
    {
        public static void WriteLine(List<string> list)
        {
            foreach (var item in list)
            {
                Debug.WriteLine(item);
            }
        }
    }
}
