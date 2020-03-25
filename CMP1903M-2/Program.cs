using System;
using System.IO;

namespace CMP1903M_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("\nEnter the first text file to compare: ");
            string file1Name = Console.ReadLine();
            Console.Write("Enter the second text file to compare: ");
            string file2Name = Console.ReadLine();

            Console.Write("[Input] diff ");
            Console.Write(file1Name);
            Console.Write(".txt ");
            Console.Write(file2Name);
            Console.Write(".txt\n");

            string directory = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string path = Path.GetFullPath(Path.Combine(directory, @"..\"));

            try
            {
                System.IO.StreamReader file1 = File.OpenText(path + file1Name + ".txt");
                System.IO.StreamReader file2 = File.OpenText(path + file2Name + ".txt");

                string file1Text = file1.ReadToEnd();
                string file2Text = file2.ReadToEnd();

                if (file1Text == file2Text)
                {
                    Console.Write("[Output] ");
                    Console.Write(file1Name);
                    Console.Write(" and ");
                    Console.Write(file2Name);
                    Console.Write(" are not different\n\n");
                }
                else
                {
                    Console.Write("[Output] ");
                    Console.Write(file1Name);
                    Console.Write(" and ");
                    Console.Write(file2Name);
                    Console.Write(" are different\n\n");
                }
            }
            catch
            {
                Console.WriteLine("Please enter the name of a valid text file in the current directory");
                Main();
            }

            Main();
            

        }
    }
}
