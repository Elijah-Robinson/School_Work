using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {

            int y = 0;
            while (y < 1)
            {
                string input = "";
                try
                {
                    int x = 0;
                    while (x < 1)
                    {
                        int p = 0;

                        Console.WriteLine("Document\n");
                        Console.WriteLine("Enter the name of your document: ");
                        string docName = Console.ReadLine();
                        if (docName.Contains(".txt"))
                        {
                            p = p + 1;
                        }
                        else if (docName.Contains(".txt") == false)
                        {
                            docName = docName + ".txt";
                            p = p + 1;
                        }
                        else
                        {

                        }

                        if (p == 1)
                        {
                            using (StreamWriter File = new StreamWriter(docName))
                            {
                                Console.WriteLine("Enter your line of text");
                                input = Console.ReadLine();
                                File.WriteLine(input);
                            }


                            var numOfWords = input.Split(' ');


                            Console.WriteLine($"{docName} was succsessfully saved. The document contains {numOfWords.Count()} words.");
                        }

                        Console.WriteLine("Would you like to create a new document? Y/N");
                        string choice1 = Console.ReadLine();
                        if (choice1 == "Y")
                        {

                        }
                        else if (choice1 == "N")
                        {
                            x = x + 1;
                        }

                    }
                    y = y + 1;
                }
                catch
                {
                    Console.WriteLine("Error. Something went wrong");
                }
            }
        }
    }
}

