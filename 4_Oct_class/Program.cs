using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Oct_class
{
    public delegate string MyDelegate(string name);

    public class Myclass{

        public string Name1(string name)
        {
            return name.ToUpper();
        }

        public string Name2(string name)
        {
            return name.ToLower();
        }

    }
    

    internal class Program
    {
        static void Main(string[] args)
        {

            Myclass m = new Myclass();
            MyDelegate d = new MyDelegate(m.Name1);
            d += new MyDelegate(m.Name2);

            Delegate[] list = d.GetInvocationList();

            foreach (Delegate item in list)
            {
                //Console.WriteLine(item);
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke("Abhay"));

            }




        }
    }
}
