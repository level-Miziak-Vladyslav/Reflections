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

                string str;
                FileStream fout;

                // First, open the file stream. 
                try
                {
                    fout = new FileStream(c.Name+".txt", FileMode.Create);
                }
                catch (IOException exc)
                {
                    Console.WriteLine("Error Opening File:\n" + exc.Message);
                    return;
                }
                StreamWriter fstr_out = new StreamWriter(fout);


                try
                {
                    foreach (PropertyInfo prop in c.GetProperties())
                    {
                    Console.WriteLine("{0} {1} {2}", prop.PropertyType, prop.Name, prop.GetValue(N));
                        str = prop.Name + ":"+prop.GetValue(N)+"\r\n"; // add newline  
                        fstr_out.Write(str);
                    }
                }

                catch (IOException exc)
                {
                    Console.WriteLine("I/O Error:\n" + exc.Message);
                }
                finally
                {
                    fstr_out.Close();
                }

                // Display methods supported by MyClass. 
                Console.WriteLine(")");


            }
            Console.ReadKey();
            FileStream fin;
            string s;
            Console.WriteLine();

            foreach (Things N in tc)
            {
                Type c = N.GetType(); // get a Type object representing MyClass 
                Console.WriteLine("Creating property in " + c.Name);
                Console.WriteLine();
                // First, open the file stream. 
                try
                {
                    fin = new FileStream(c.Name + ".txt", FileMode.Open);
                }
                catch (IOException exc)
                {
                    Console.WriteLine("Error Opening file:\n" + exc.Message);
                    return;
                }
                StreamReader fstr_in = new StreamReader(fin);
                try
                {
                    while ((s = fstr_in.ReadLine()) != null)
                    {
                        string[] words = s.Split(new char[] { ':' });
                        PropertyInfo piShared = c.GetProperty(words[0]);
                        int number;
                        if (int.TryParse(words[1], out number))
                        {
                            piShared.SetValue(N, number);
                        }
                        else
                        {
                            piShared.SetValue(N, words[1]);
                        }
                   }
                }
                catch (IOException exc)
                {
                    Console.WriteLine("I/O Error:\n" + exc.Message);
                }
                finally
                {
                    fstr_in.Close();
                }
            }
            foreach (Things N in tc)
            {
                Type c = N.GetType(); // get a Type object representing MyClass 
                N.name = c.ToString();
                Console.WriteLine("Analyzing methods in " + c.Name);
                Console.WriteLine();

                Console.WriteLine("Methods supported: ");
                // First, open the file stream. 
                try
                {
                    foreach (PropertyInfo prop in c.GetProperties())
                    {
                        Console.WriteLine("{0} {1} {2}", prop.PropertyType, prop.Name, prop.GetValue(N));
                    }
                }

                catch (IOException exc)
                {
                    Console.WriteLine("I/O Error:\n" + exc.Message);
                }
                    // Display methods supported by MyClass. 
                Console.WriteLine(")");
            }
            // Wrap the file stream in a StreamReader. 
        }
    }
}


