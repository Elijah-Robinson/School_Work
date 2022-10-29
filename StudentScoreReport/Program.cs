using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StudentScoreReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your name: ");
            string nameinpuit = Console.ReadLine();

            Console.WriteLine("Input the name of the file to be processed: ");
            string docName = Console.ReadLine();

            int x = 0;

            while (x < 1)
            {
                if (docName.Contains(".csv"))
                {
                    x = x + 1;
                }
                else if (docName.Contains(".csv") == false)
                {
                    docName = docName + ".csv";
                    x = x + 1;
                }
                else
                {
                }
            }

            int totalStuds = 0;

            List<double> scores = new List<double>();


            StreamReader fileRead = new StreamReader(docName);
            while (!fileRead.EndOfStream)
            {
                string info = fileRead.ReadLine();

                string[] data = info.Split(",");

                string fName = data[0];
                string lName = data[1];
                string fullName = fName + " " + lName;
                int creditHours = int.Parse(data[2]);
                string major = data[3];
                float examOne = float.Parse(data[4]);
                float examTwo = float.Parse(data[5]);
                float examThree = float.Parse(data[6]);

                totalStuds = totalStuds + 1;

                double studentAvg = avgScore(examOne, examTwo, examThree);

                scores.Add(studentAvg);

                studInfo(fullName, creditHours, major, examOne, examTwo, examThree);

            }

            summaryReport(totalStuds, scores);


        }

        //output Num of students, avg score, max and min score. 
        static void summaryReport(int totalStuds, List<double> scores)
        {
            using (StreamWriter fileWriter = new StreamWriter("scoresLog.txt"))
            {
                double totalAVG = totAVG(scores, totalStuds);

                double min = scores.Min();
                double max = scores.Max();

                fileWriter.WriteLine("Total ammount of students is " + totalStuds);
                fileWriter.WriteLine("The total average between all students is " + totalAVG + "%");
                fileWriter.WriteLine("The minimum average is " + min + "%");
                fileWriter.WriteLine("The maximum average is " + max + "%");


            }



        }


        //fresh, soph, juin, or senior
        static string whatGrade(int creditHours)
        {
            string grade = "";

            if (creditHours >= 90)
            {
                grade = "Senior";
            }
            else if (creditHours <= 89 && creditHours >= 60)
            {
                grade = "Junior";
            }
            else if (creditHours >= 30 && creditHours <= 59)
            {
                grade = "Sophmore";
            }
            else
            {
                grade = "Freshman";
            }
            return grade;

        }

        //avg score of every student
        static double avgScore(float examOne, float examTwo, float examThree)
        {
            double sum = examOne + examTwo + examThree;
            double score = sum / 3;

            score = Math.Round(score, 2);

            return score;
        }

        static double totAVG(List<double> scores, int totalStuds)
        {
            double sum = scores.Sum();

            double totalAverage = sum / totalStuds;

            totalAverage = Math.Round(totalAverage, 2);

            return totalAverage;
        }

        //[Student name]: [student class]([major]) \n Average Score: [student average]%
        static void studInfo(string fullName, int creditHours, string major, float examOne, float examTwo, float examThree)
        {
            Console.WriteLine(fullName + ": " + whatGrade(creditHours) + " (" + major + ")");
            Console.WriteLine("Average Score: " + avgScore(examOne, examTwo, examThree) + "%\n");
        }
    }
}
