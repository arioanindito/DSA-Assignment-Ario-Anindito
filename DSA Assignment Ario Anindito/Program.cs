using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA_Assignment_Ario_Anindito
{
    class Program
    {
        static void Main (string[] args)
        {
            Assignment();
        }

        static void Assignment()
        {
            object[] Average_scores;
            CustomDataList Test = new CustomDataList();

            while (true)
            {
                try

                {
                    Console.WriteLine("");
                    Console.WriteLine("Main Menu");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("1. Populate With Sample Data");
                    Console.WriteLine("2. Input New Element");
                    Console.WriteLine("3. Get Element by Index");
                    Console.WriteLine("4. Delete Element by Index");
                    Console.WriteLine("5. Remove First Element ");
                    Console.WriteLine("6. Remove Last Element");
                    Console.WriteLine("7. Display All Element");
                    Console.WriteLine("8. View All Element (Ascending Index)");
                    Console.WriteLine("9. View All Element (Descending Index)");
                    Console.WriteLine("10. Highest Score Student");
                    Console.WriteLine("11. Lowest Score Student");
                    Console.WriteLine("12. Exit");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Input: ");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input > 0 && input <= 12)
                    {
                        switch (input)
                        {
                            case 1:
                                Test.PopulateWithSampleData();
                                Console.WriteLine("");
                                Console.WriteLine("Sample Data Added!");
                                break;

                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Input New Data");
                                Console.WriteLine("----------------------------------");
                                Console.Write("Student First Name: ");
                                string FirstName = Console.ReadLine();
                                Console.Write("Student Last Name: ");
                                string LastName = Console.ReadLine();
                                Console.Write("Student Number: ");
                                string StudentNumber = Console.ReadLine();
                                Console.Write("Student Average Score: ");
                                float AverageScore = (float)Convert.ToDouble(Console.ReadLine());

                                Test.Add(FirstName, LastName, StudentNumber, AverageScore);
                                break;

                            case 3:
                                Console.WriteLine("");
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Enter the index of the element to display:");
                                Console.WriteLine("----------------------------------");
                                int Index = Convert.ToInt32(Console.ReadLine()) - 1;

                                object[] Student = Test.GetElement(Index);
                                Console.WriteLine();
                                Console.WriteLine("Student First Name: " + Student[0]);
                                Console.WriteLine("Student Last Name: " + Student[1]);
                                Console.WriteLine("Student Number: " + Student[2]);
                                Console.WriteLine("Average Score: " + Student[3]);
                                break;

                            case 4:
                                Console.WriteLine("");
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Enter the Index of the element to delete: ");
                                Console.WriteLine("----------------------------------");
                                int index = Convert.ToInt32(Console.ReadLine()) - 1;
                                Test.RemoveByIndex(index);
                                Console.Write("Index Data Number ");
                                Console.Write(index+1);
                                Console.WriteLine(" deleted!");
                                break;

                            case 5:
                                Test.RemoveFirst();
                                Console.WriteLine("");
                                Console.WriteLine("First Index Data Removed!");
                                break;

                            case 6:
                                Test.RemoveLast();
                                Console.WriteLine("");
                                Console.WriteLine("Last Index Data Removed!");
                                break;

                            case 7:
                                Test.DisplayList();
                                Console.WriteLine("");
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Display All Data: ");
                                Console.WriteLine("----------------------------------");
                                break;

                            case 8:
                                Console.WriteLine("");
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Display All Data (Ascending Index): ");
                                Console.WriteLine("----------------------------------");
                                Test.AscendingIndex();
                                break;

                            case 9:
                                Console.WriteLine("");
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Display All Data (Descending Index): ");
                                Console.WriteLine("----------------------------------");
                                Test.DescendingIndex();
                                break;

                            case 10:
                                Average_scores = Test.Highest_Score;
                                Console.WriteLine("Highest Score Student");
                                Console.WriteLine("First Name: " + Average_scores[0]);
                                Console.WriteLine("Last Name: " + Average_scores[1]);
                                Console.WriteLine("Student ID: " + Average_scores[2]);
                                Console.WriteLine("Average Score: " + Average_scores[3]);
                                break;

                            case 11:
                                Average_scores = Test.Lowest_Score;
                                Console.WriteLine("Lowest Score Student");
                                Console.WriteLine("First Name: " + Average_scores[0]);
                                Console.WriteLine("Last Name: " + Average_scores[1]);
                                Console.WriteLine("Student ID: " + Average_scores[2]);
                                Console.WriteLine("Average Score: " + Average_scores[3]);
                                break;

                            case 12:
                                goto breakout;

                            default:
                                break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press Enter key to back to the main menu");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                        Console.WriteLine("Please enter correct number!");
                }

                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error, Please try again!");
                }
            }
        breakout:;
        }
    }
}