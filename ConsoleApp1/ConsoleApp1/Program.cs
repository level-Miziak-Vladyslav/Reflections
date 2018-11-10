using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Type t = typeof(Car); // get a Type object representing MyClass 

            Console.WriteLine("Analyzing methods in " + t.Name);
            Console.WriteLine();

            Console.WriteLine("Methods supported: ");

            MethodInfo[]  mi = t.GetMethods();

            // Display methods supported by MyClass. 
            foreach (MethodInfo m in mi)
            {
                // Display return type and name. 
                Console.Write("   " + m.ReturnType.Name +
                                " " + m.Name + "(");

                // Display parameters. 
                ParameterInfo[] pi = m.GetParameters();

                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name +
                                  " " + pi[i].Name);
                    if (i + 1 < pi.Length) Console.Write(", ");
                }

                Console.WriteLine(")");

                Console.WriteLine();
            }
        }
    }

}
