using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Mysql;

namespace Reflection
{
    class Program
    {
        /// <summary>
        /// 1、dll-IL-metadata-反射
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Test.CommonMethod();
            Test.LoadDLL();
        }
    }
}
