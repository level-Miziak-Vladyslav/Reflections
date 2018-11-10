using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Things
    {
        int quantity { get; set; }
        string name { get; set; }
    }
    class Car:Things
    {
        int capasity { get; set; }
        void Drive()
        {
            Console.WriteLine("RUNNING");
        }
    }
    class Tree:Things
    {
        int height { get; set; }
        void Grow()
        {
            Console.WriteLine("GROWING");
        }
    }
    class Pet:Things
    {
        void Feed()
        {
            Console.WriteLine("FEEDING");
        }
    }

}
