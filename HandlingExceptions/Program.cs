using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\users\lx389\Documents\Leson.txt");
                Console.WriteLine(content);

            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("There is a problem!");
                Console.WriteLine(ex);
                Console.WriteLine();
                Console.WriteLine("Please make sure the name of the file is named correctly: Lesson.txt");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("There is a problem!");
                Console.WriteLine(ex);
                Console.WriteLine();
                Console.WriteLine(@"Please make sure the directory: C:\Users\lx389\Documents is exists.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("There is a problem! ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Press Enter to close application.");
                Console.ReadLine();
                Console.WriteLine("Closing Application now...");
            }
            Console.ReadLine();
        }
    }
}
