using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Things
    {
        public int quantity { get { return 1; } set { this.quantity = 1; } }
        public string name { get; set; }
    }
    class Car :Things
    {
        int capasity { get { return 2; } set { this.capasity = 2; } }
        void Drive()
        {
            Console.WriteLine("RUNNING");
        }
    }
    class Tree :Things
    {
        int height { get { return 3; } set { this.height = 3; } }
        void Grow()
        {
            Console.WriteLine("GROWING");
        }
    }
    class Pet :Things
    {
        void Feed()
        {
            Console.WriteLine("FEEDING");
        }
    }



}
