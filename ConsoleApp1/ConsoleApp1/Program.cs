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
            Things[] tc = new Things[3];
            tc[0] = new Car();
            tc[1] = new Tree();
            tc[2] = new Pet();
            foreach (Things N in tc)
            {

                Type c = N.GetType(); // get a Type object representing MyClass 
                N.name = c.ToString();
                Console.WriteLine("Analyzing methods in " + c.Name);
                Console.WriteLine();

                Console.WriteLine("Methods supported: ");

                MethodInfo[] mi = c.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

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
                        Console.WriteLine(pi[i].ParameterType.Name +
                                      " " + pi[i].Name);
                        if (i + 1 < pi.Length) Console.Write(", ");
                    }
                }
                Console.WriteLine(")");

                Console.WriteLine();
            }
        }
    }

}
