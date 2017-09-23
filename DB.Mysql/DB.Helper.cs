using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Interface;

namespace DB.Mysql
{
    public class DBHelper : IDBHelper
    {
        public int _Number;
        public int _ID { get; set; }
        public string _Name { get; set; }
        public DBHelper ()
        {
            Console.WriteLine("调用{0}无参的构造函数", this.GetType().FullName);
        }
        public void Query()
        {
            Console .WriteLine ("这里是{0}数据库查询",this .GetType ().FullName );
        }
    }
}
