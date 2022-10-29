using System;
using System.Collections.Generic;


// Improving grade converter. 
/*  
When refactoring your code you should write functions that do the following:
    Write a function that gets and returns the user's first and last name.
    Write a function that gets and returns the number of grades the user wants to enter.
    Write a function that adds the grades the user enters to a list. The function should return a list of grades
    Write a function that prints the letter grades and the numerical scores for the grades stored in the grades list e.g. (A score of  89.5 is a B grade)
    Write a function that prints the statistics for the grades list. (number of grades, average grade, maximum grade, minimum grade)
You should write new functions to carry do the following:
    Write a function that calculates and returns the average grade
    Write a function that determines and returns the highest grade in the list of grades
    Write a function that determines and returns the lowest grade in the list of grades
*/

namespace GradeConverter
{
    class Program
    {
        // MAIN
        static void Main(string[] args)
        {
            List<double> gradedLst = new List<double>();

            Console.WriteLine("Enter your First name.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last name.");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + " " + lastName + " welcome to the Grade Converter!");

            int p = 0;
            while (p < 1)
            {

                Console.WriteLine("\nEnter amount of grades you want to submit.");

                int ammountOfGrades = int.Parse(Console.ReadLine());


                for (int y = 0; y < ammountOfGrades; y = y + 1)
                {
                    double grade = funcGetNum();
                    if (0.0 <= grade && 100.00 >= grade)
                    {
                        gradedLst.Add(grade);
                    }
                    else if (0.0 <= grade || 100.01 > grade)
                    {
                        Console.WriteLine("Grades have to be between 0.01 and 100.");
                        y = y - 1;
                    }
                }


                foreach (float grade in gradedLst)
                {
                    string letter = conversionGrade(grade);

                    Console.WriteLine(grade + " is a " + letter);
                }

                Console.WriteLine("Grade Statistics\n-------------------------");


                gradeStats(gradedLst);


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
                            }
                            else if (answer == "No")
                            {
                                m = m + 1;
                                L++;
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
                        p = p + 1;
                    }
                    else
                    {
                        Console.WriteLine("You entered something other than 'Yes' or 'No'.");
                    }
                }
            }


        }

        //CONVERSION FROM NUMBER TO LETTER
        static string conversionGrade(double grade1)
        {
            string finalGrade = "";

            if (grade1 < 60)
            {
                finalGrade = "F";
            }
            else if (grade1 >= 60 && grade1 < 70)
            {
                finalGrade = "D";
            }
            else if (grade1 >= 70 && grade1 < 80)
            {
                finalGrade = "C";
            }
            else if (grade1 >= 80 && grade1 < 90)
            {
                finalGrade = "B";
            }
            else if (grade1 >= 90 && grade1 < 100.01)
            {
                finalGrade = "A";
            }

            return finalGrade;
        }


        //Grading Statistics
        static void gradeStats(List<double> gradedLst)
        {
            double x = 0.0;
            double y = 0.0;

            foreach (double value in gradedLst)
            {
                x = x + value;

            }
            y = x / gradedLst.Count;

            y = Math.Round(y, 2);

            Console.WriteLine("Number of grades is " + gradedLst.Count);
            Console.WriteLine("Average grade: " + y + " which is a " + conversionGrade(y));

        }

        //ENTER GRADE ONCE PROMTED HAS TRY EXCEPT 
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
