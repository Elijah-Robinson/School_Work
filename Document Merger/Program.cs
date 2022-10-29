using System;
using System.IO;


namespace Document_Merger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document\n");
            string fileOne = "";
            string fileTwo = "";
            bool question = true;

            int x = 0;
            while (x < 1)
            {
                Console.WriteLine("Enter the first merged file.");
                fileOne = Console.ReadLine();

                while (fileOne.Length > 0)
                {
                    if (question)
                    {
                        question = false;
                        x = x + 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Filename");
                    }

                }
            }
            question = true;

            int y = 0;
            while (y < 1)
            {
                Console.WriteLine("Enter the first merged file.");
                fileTwo = Console.ReadLine();
                while (fileTwo.Length > 0 && !File.Exists(fileTwo))
                {
                    if (question)
                    {
                        question = false;
                        y = y + 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Filename");
                    }
                }
            }

            String merged = fileOne.Substring(0, fileOne.Length - 4) + fileTwo.Substring(0, fileTwo.Length - 4) + ".txt";

            StreamWriter AA = null;
            StreamReader BA = null;
            StreamReader BB = null;

            bool worked = false;

            float num = 0;


            AA = new StreamWriter(merged);
            BA = new StreamReader(fileOne);
            BB = new StreamReader(fileTwo);

            String line = BA.ReadLine();

            while (line != null)
            {
                AA.WriteLine(line);
                num += line.Length;
                line = BA.ReadLine();
            }

            line = BB.ReadLine();

            while (line != null)
            {
                AA.WriteLine(line);
                num += line.Length;
                line = BB.ReadLine();
            }
            worked = true;
        }



        Console.WriteLine(merged + " was successfully saved. This document contains " + num + " characters.");
    }
}


