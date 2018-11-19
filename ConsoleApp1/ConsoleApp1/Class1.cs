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
        public Things()
        {
            name = "things";
        }
    }
    class Car :Things
    {
        public int capasity { get; set; }
        public Car()
        {
            quantity = 1;
            name = "BMW";
            capasity = 5;
        }
        void Drive()

        {
            Console.WriteLine("RUNNING");
        }
    }
    class Tree :Things
    {
        public int height { get; set; }
        public Tree()
        {
            quantity = 2;
            name = "Oak";
            height = 4;
        }
        void Grow()
        {
            Console.WriteLine("GROWING");
        }
    }
    class Pet :Things
    {
        public Pet()
        {
            name = "things";
        }

        void Feed()
        {
            Console.WriteLine("FEEDING");
        }
    }



}
