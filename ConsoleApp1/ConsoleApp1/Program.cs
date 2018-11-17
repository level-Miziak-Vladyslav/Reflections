using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

                PropertyInfo[] pi = c.GetProperty(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

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
            string str;
            FileStream fout;

            // First, open the file stream. 
            try
            {
                fout = new FileStream("test.txt", FileMode.Create);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error Opening File:\n" + exc.Message);
                return;
            }

            // Wrap the file stream in a StreamReader. 
            StreamWriter fstr_out = new StreamWriter(fout);

            try
            {
                Console.WriteLine("Enter text ('stop' to quit).");

                do
                {
                    Console.Write(": ");
                    str = Console.ReadLine();

                    if (str != "stop")
                    {
                        str = str + "\r\n"; // add newline  
                        fstr_out.Write(str);
                    }
                } while (str != "stop");
            }
            catch (IOException exc)
            {
                Console.WriteLine("I/O Error:\n" + exc.Message);
            }
            finally
            {
                fstr_out.Close();
            }
        }
    }
}


