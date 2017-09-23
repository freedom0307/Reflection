using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.SqlServer
{
    public class DBHelper
    {
        public DBHelper()
        {
            Console.WriteLine("调用{0}无参的构造函数", this.GetType().FullName);
        }
        public void Query()
        {
            Console.WriteLine("这里是{0}数据库查询", this.GetType().FullName);
        }
    }
}
