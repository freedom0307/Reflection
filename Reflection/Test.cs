using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Mysql;
using System.Reflection;
using DB.Interface;
namespace Reflection
{
    public  class Test
    {
        public static DBHelper _DBHelper = new DBHelper();
        public static Assembly _Assembly1, _Assembly2, _Assembly3 ;
        /// <summary>
        /// 普通方法创建对象并调用方法
        /// </summary>
        public static void CommonMethod ()
        {
            Console.WriteLine("调用普通方法");
            _DBHelper.Query();
        }
        /// <summary>
        /// 加载DLL的三种方式
        /// </summary>
        public static void LoadDLL ()
        {
            Console.WriteLine("发射加载DLL");
            _Assembly1 = Assembly.Load("DB.Mysql");
            _Assembly2 = Assembly.LoadFile(@"E:\专业学习\C#\Project\Reflection\Reflection\bin\Debug\DB.Mysql.dll");
            _Assembly3 = Assembly.LoadFrom("DB.Mysql.dll");
            Console.WriteLine("GetModules()");
            foreach (var temp in _Assembly1.GetModules() )
            {
                Console.WriteLine("模块全称为:{0}", temp.Name);
                Console.WriteLine("模块全称为:{0}", temp.FullyQualifiedName );
            }
            Console.WriteLine("GetTypes()");
            foreach (var temp in _Assembly1.GetTypes())
            {
                Console.WriteLine("Type名称为:{0}", temp.Name);
                Console.WriteLine("Type名称为:{0}", temp.FullName );
            }
            //Type _Type = _Assembly1.GetType("DB.Mysql");//错误的写法
            Type _Type = _Assembly1.GetType("DB.Mysql.DBHelper");
            Console.WriteLine("GetConstructors ()");
            foreach (var temp in _Type .GetConstructors ())
            {
                Console.WriteLine(temp.Name );
            }
            Console.WriteLine("GetProperties()");
            foreach (var temp in _Type .GetProperties())
            {
                Console.WriteLine(temp.Name);
            }
            Console.WriteLine("GetMethods ()");
            foreach (var temp in _Type .GetMethods ())
            {
                Console.WriteLine(temp.Name);
            }
            Console.WriteLine("GetFields()");
            foreach (var temp in _Type .GetFields())
            {
                Console.WriteLine(temp.Name);
            }
            Console.WriteLine("利用反射创建对象");
            object _Ojb= Activator.CreateInstance(_Type);
            IDBHelper _Instance = (IDBHelper)_Ojb;
            _Instance.Query();
            Console.WriteLine("利用反射+简单工厂+配置文件创建对象");

        }
    }
}
