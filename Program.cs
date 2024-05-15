using System.IO;

namespace Assignment2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string myName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string myAge = Console.ReadLine();
            Console.WriteLine("Enter your address: ");
            string myaddress = Console.ReadLine();
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\MSSA-CCAD14\\Test.txt");
                //Write a line of text
                sw.WriteLine("Hello!! My name is " + myName);
                //Write a second line of text
                sw.WriteLine("From Class CCAD14!");
                //Close the file
                sw.WriteLine("I'm " + myAge + " years old and I live in " + myaddress);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\MSSA-CCAD14\\Test.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
