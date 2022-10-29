using System;
using System.Collections.Generic;

namespace GradeConverter
{
    class Program
    {
        // MAIN
        static void Main(string[] args)
        {

            List<double> gradedLst = new List<double>();
            int rando = 0;
            while (rando < 1)
            {
                string userUame = getName();
                //numbOfGrades(gradedLst);

                double Grades = numbOfGrades(gradedLst);
                List<float> scores = new List<float>();

                for (int fire = 0; fire < Grades; fire++)
                {
                    gradedLst.Add(funcGetNum());
                }
                averageGradeFunc(gradedLst);

                gradeStats(gradedLst);
                Console.WriteLine("______________________");

                moreGrades(gradedLst, 0);
            }

        }

        // first and last function
        static string getName()
        {

            Console.WriteLine("Enter your first name and last name.");
            string theName = Console.ReadLine();
            return theName;
        }
        //number of grades user wants to imput
        static double numbOfGrades(List<double> gradedLst)
        {
            Console.WriteLine("\nEnter amount of grades you want to submit.");
            double ammountOfGrades = double.Parse(Console.ReadLine());

            return ammountOfGrades;
        }
        //add more grades function? Hard time implementing this one...
        static void moreGrades(List<double> gradedLst, int rando)
        {
            int m = 0;
            while (m < 1)
            {
                Console.WriteLine("Do you want to enter more grades? Yes/No");
                string moreGrades = Console.ReadLine();
                if (moreGrades == "Yes")
                {
                    Console.WriteLine("Do you want to clear the previous grades? Yes/No.");
                    string answer = Console.ReadLine();
                    int L = 0;
                    while (L < 1)
                    {
                        if (answer == "Yes")
                        {
                            m = m + 1;
                            gradedLst.Clear();
                            L++;
                            numbOfGrades(gradedLst);
                        }
                        else if (answer == "No")
                        {
                            m = m + 1;
                            L++;
                            numbOfGrades(gradedLst);
                        }
                        else
                        {
                            Console.WriteLine("You entered something wrong.");
                        }
                    }
                }
                else if (moreGrades == "No")
                {
                    m = m + 1;
                    rando = rando + 1;
                }
                else
                {
                    Console.WriteLine("You entered something other than 'Yes' or 'No'.");
                }
            }
        }
        //average grade function
        static void averageGradeFunc(List<double> gradedLst)
        {
            foreach (float grade in gradedLst)
            {
                string letter = conversionGrade(grade);
                Console.WriteLine(grade + " is a " + letter);
            }
        }

        //CONVERSION FROM NUMBER TO LETTER
        static string conversionGrade(double gradeParam)
        {
            string finalGrade = "";

            if (gradeParam < 60)
            {
                finalGrade = "F";
            }
            else if (gradeParam >= 60 && gradeParam < 70)
            {
                finalGrade = "D";
            }
            else if (gradeParam >= 70 && gradeParam < 80)
            {
                finalGrade = "C";
            }
            else if (gradeParam >= 80 && gradeParam < 90)
            {
                finalGrade = "B";
            }
            else if (gradeParam >= 90 && gradeParam < 100.01)
            {
                finalGrade = "A";
            }
            return finalGrade;
        }


        //Grading Statistics function
        static void gradeStats(List<double> gradedLst)
        {
            double x = 0.0;
            double y = 0.0;
            double maximumGrade = maxGrade(gradedLst);
            double minimumGrade = minGrade(gradedLst);

            foreach (double value in gradedLst)
            {
                x = x + value;
            }
            y = x / gradedLst.Count;
            y = Math.Round(y, 2);
            Console.WriteLine("Number of grades is " + gradedLst.Count);
            Console.WriteLine("Average grade: " + y + " which is a " + conversionGrade(y));
            Console.WriteLine("Maximum grade: " + maximumGrade + " which is a " + conversionGrade(maximumGrade));
            Console.WriteLine("Minimum grade: " + minimumGrade + " which is a " + conversionGrade(minimumGrade));

        }


        //Max and Min grade function below
        static double maxGrade(List<double> gradedLst)
        {
            double max = double.MinValue;
            foreach (double grade in gradedLst)
            {
                if (grade > max)
                {
                    max = grade;
                }
            }

            return max;
        }

        static double minGrade(List<double> gradedLst)
        {
            double min = double.MaxValue;
            foreach (double grade in gradedLst)
            {
                if (grade < min)
                {
                    min = grade;
                }
            }

            return min;

        }


        //Enter grade function
        static double funcGetNum()
        {
            double input;
            try
            {
                Console.WriteLine("Enter a grade.");
                input = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                return -1;
            }
            return input;
        }
    }
}


