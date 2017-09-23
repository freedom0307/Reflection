using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Interface;
using System.Configuration;
using System.Reflection;

namespace SimpleFactory
{
    public class Factory
    {
        public static string _TypeName = ConfigurationManager.AppSettings["IDBHelper"];
        public static IDBHelper CreateInstance()
        {
            string _DllName = _TypeName.Split(',')[1];
            string _ClassNmae = _TypeName.Split(',')[0];
            Assembly _Assembly = Assembly.Load(_DllName );
            Type _Type = _Assembly.GetType(_ClassNmae );
            IDBHelper _DBH = (IDBHelper )Activator.CreateInstance(_Type);
            return _DBH;
        }
    }
}
