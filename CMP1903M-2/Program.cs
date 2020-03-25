using System;
using System.IO;

namespace CMP1903M_2
{
    class Program
    {
        static void Main()
        {
            //User enters the name of the two text files to compare, names are stored in string format
            Console.Write("\nEnter the first text file to compare (Do not include .txt): ");
            string file1Name = Console.ReadLine();
            Console.Write("Enter the second text file to compare (Do not include .txt): ");
            string file2Name = Console.ReadLine();

            //Input is displayed to the user
            Console.Write("[Input] diff ");
            Console.Write(file1Name);
            Console.Write(".txt ");
            Console.Write(file2Name);
            Console.Write(".txt\n");

            //Gets the current directory
            string directory = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string path = Path.GetFullPath(Path.Combine(directory, @"..\"));

            //Try/Catch to handle if the user enters an invalid text file
            try
            {
                //Stores the two text files
                System.IO.StreamReader file1 = File.OpenText(path + file1Name + ".txt");
                System.IO.StreamReader file2 = File.OpenText(path + file2Name + ".txt");

                //Reads through both text files and stores contents to string
                string file1Text = file1.ReadToEnd();
                string file2Text = file2.ReadToEnd();

                //Determines if the files contents are the same or not and displays result to the user
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
                //Displays error to the user and restarts process
                Console.WriteLine("Please enter the name of a valid text file in the current directory");
                Main();
            }

            //Restarts process
            Main();
            

        }
    }
}
