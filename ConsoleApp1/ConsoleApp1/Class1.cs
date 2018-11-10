using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Things
    {
        public int quantity { get; set; }
        public string name { get; set; }
    }
    public class Car :Things
    {
        public int capasity { get; set; }
        public void Drive()
        {
            Console.WriteLine("RUNNING");
        }
    }
    public class Tree :Things
    {
        public int height { get; set; }
        public void Grow()
        {
            Console.WriteLine("GROWING");
        }
    }
    public class Pet :Things
    {
        public void Feed()
        {
            Console.WriteLine("FEEDING");
        }
    }



}
