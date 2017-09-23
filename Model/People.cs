using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class People:BaseModel
    {
        public string _Job { get; set; }
        public string _Hobby { get; set; }
        public double _Money { get; set; }
        public void Eat ()
        {
            Console.WriteLine("吃饭");
        }
        public void Work()
        {
            Console.WriteLine("工作");
        }
        public void Travle()
        {
            Console.WriteLine("旅游");
        }
    }
}
