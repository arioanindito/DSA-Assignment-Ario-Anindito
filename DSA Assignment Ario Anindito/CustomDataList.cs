using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DSA_Assignment_Ario_Anindito
{
    class CustomDataList
    {
        public object[] student = new object[4];
        public int Length = 0;
        public object[] First = new object[4];
        public object[] Last = new object[4];

        public float MaxElement = 10;
        public float MinElement = 0;

        public object[] Highest_Score = new object[4];
        public object[] Lowest_Score = new object[4];

        public Dictionary<int, object[]> Nan = new Dictionary<int, object[]>();


        public void PopulateWithSampleData()
        {
            object[] Student1 = new object[4];
            Student1[0] = "Alice";
            Student1[1] = "Dubois";
            Student1[2] = "VUM-111111";
            Student1[3] = "70";
            Nan.Add(Length, Student1);
            Length++;

            object[] Student2 = new object[4];
            Student2[0] = "Maxime";
            Student2[1] = "Barbier";
            Student2[2] = "VUM-222222";
            Student2[3] = "77";
            Nan.Add(Length, Student2);
            Length++;

            object[] Student3 = new object[4];
            Student3[0] = "Nicolas";
            Student3[1] = "Dumont";
            Student3[2] = "VUM-333333";
            Student3[3] = "82";
            Nan.Add(Length, Student3);
            Length++;

            object[] Student4 = new object[4];
            Student4[0] = "Quentin";
            Student4[1] = "Muller";
            Student4[2] = "VUM-444444";
            Student4[3] = "86";
            Nan.Add(Length, Student4);
            Length++;

            object[] Student5 = new object[4];
            Student5[0] = "Sarah";
            Student5[1] = "Ziane";
            Student5[2] = "VUM-555555";
            Student5[3] = "93";
            Nan.Add(Length, Student5);
            Length++;

            Last[0] = Student5[0];
            Last[1] = Student5[1];
            Last[2] = Student5[2];
            Last[3] = Student5[3];

            Highest_Score[0] = Student5[0];
            Highest_Score[1] = Student5[1];
            Highest_Score[2] = Student5[2];
            Highest_Score[3] = Student5[3];

            Lowest_Score[0] = Student1[0];
            Lowest_Score[1] = Student1[1];
            Lowest_Score[2] = Student1[2];
            Lowest_Score[3] = Student1[3];

        }

        public void Add(string FirstName, string LastName, string StudentNumber, float AverageScore)
        {
            Console.WriteLine("");
            Console.WriteLine("New Data Successfully Added!");
            Console.Write("Data Index Number: ");
            Console.WriteLine(Length + 1);
            object[] Student = new object[4];
            Student[0] = FirstName;
            Student[1] = LastName;
            Student[2] = StudentNumber;
            Student[3] = AverageScore;

            Last[0] = FirstName;
            Last[1] = LastName;
            Last[2] = StudentNumber;
            Last[3] = AverageScore;


            Nan.Add(Length, Student);

            if (Length == 0)
            {
                MaxElement = AverageScore;
                Highest_Score = Student;

                MinElement = AverageScore;
                Lowest_Score = Student;

                First[0] = FirstName;
                First[1] = LastName;
                First[2] = StudentNumber;
                First[3] = AverageScore;
            }
            else if (AverageScore > MaxElement)
            {
                MaxElement = AverageScore;
                Highest_Score = Student;
            }
            else
            {
                MinElement = AverageScore;
                Lowest_Score = Student;
            }

            Length++;

        }

        public object[] GetElement(int Index)
        {
            if (Nan.ContainsKey(Index))
            {
                return (Nan[Index]);
            }
            else
            {
                object[] error = new object[4];

                student[0] = "";
                student[1] = "";
                student[2] = "";
                student[3] = "";
                return error;
            }
        }

        public void RemoveByIndex(int Index)
        {
            if (Index == 0)
            {
                First = Nan[1];
            }
            Nan.Remove(Index);

            while (Index + 1 < Length)
            {
                Nan.Add(Index, Nan[Index + 1]);
                Nan.Remove(Index + 1);
                Index = Index + 1;
            }

            if (Index == Length - 1)
            {
                Last = Nan[Length - 2];
            }
            Length = Length - 1;
        }

        public void RemoveFirst()
        {
            int Index = 0;
            Nan.Remove(Index);

            while (Index + 1 < Length)
            {
                Nan.Add(Index, Nan[Index + 1]);
                Nan.Remove(Index + 1);
                Index = Index + 1;
            }
            First = Nan[0];
            Length = Length - 1;
        }

        public void RemoveLast()
        {
            Nan.Remove(Length);
            Length = Length - 1;
            Last = Nan[Length - 1];
        }

        public void DisplayList()
        {
            object[] Student = new object[4];
            int count = 0;
            while (count < Length)
            {
                Student = Nan[count];
                Console.WriteLine((count + 1) + ") First Name: " + Student[0]);
                Console.WriteLine(" Last Name: " + Student[1]);
                Console.WriteLine(" Student ID: " + Student[2]);
                Console.WriteLine(" Average Score: " + Student[3]);
                Console.WriteLine();
                count++;
            }
        }

        public void AscendingIndex()
        {
            object[] Student = new object[4];
            int count = 0;


            while (count < Length)
            {
                Student = Nan[count];
                Console.WriteLine((count + 1) + ") First Name: " + Student[0]);
                Console.WriteLine(" Last Name: " + Student[1]);
                Console.WriteLine(" Student ID: " + Student[2]);
                Console.WriteLine(" Average Score: " + Student[3]);
                Console.WriteLine();
                count++;
            }

        }

        public void DescendingIndex()
        {
            object[] Student = new object[4];
            int count = Length;

            while (count > 0)
            {
                Student = Nan[count-1];
                Console.WriteLine((count) + ") First Name: " + Student[0]);
                Console.WriteLine(" Last Name: " + Student[1]);
                Console.WriteLine(" Student ID: " + Student[2]);
                Console.WriteLine(" Average Score: " + Student[3]);
                Console.WriteLine();
                count--;
            }



        }

    }

}