using System;
using System.Collections.Generic;

namespace ListMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Mysets();
        }


            static void Mysets()
            {   //sets the numbers in no order, all in one line
                //declaring your variables
                HashSet<int> evenNumbers = new HashSet<int>();
                HashSet<int> oddNumbers = new HashSet<int>();

                for (int i = 0; i < 5; i++)
                {
                    // Populate numbers with just even numbers.
                    evenNumbers.Add(i * 2);

                    // Populate oddNumbers with just odd numbers.
                    oddNumbers.Add((i * 2) + 1);
                }

                Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
                DisplaySet(evenNumbers);

                Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
                DisplaySet(oddNumbers);

                // Create a new HashSet populated with even numbers.
                HashSet<int> numbers = new HashSet<int>(evenNumbers);
                Console.WriteLine("numbers UnionWith oddNumbers...");
                //union helps concactinate both functions together.
                numbers.UnionWith(oddNumbers);

                Console.Write("numbers contains {0} elements: ", numbers.Count);
                DisplaySet(numbers);

            }

            private static void DisplaySet(HashSet<int> set)
            {
                Console.Write("{");
                foreach (int i in set)
                {
                    Console.Write(" {0}", i);
                }
                Console.WriteLine(" }");
            }

            /* This example produces output similar to the following:
             * evenNumbers contains 5 elements: { 0 2 4 6 8 }
             * oddNumbers contains 5 elements: { 1 3 5 7 9 }
             * numbers UnionWith oddNumbers...
             * numbers contains 10 elements: { 0 2 4 6 8 1 3 5 7 9 }
             */
        





        static void listAndDict()
        {


            List<string> Courses = new List<string>();
            Courses.Add("JAVA");
            Courses.Add("C#");
            Courses.Add("SQL");
            Courses.Add("HTML5");
            Courses.Add("Full Stack");
            Courses.Add("JavaScript");
            Courses.Add("Database");

            if (Courses.IndexOf("A#") != -1)
            {
                // C# class exist in our list, perform necessary operation
            }

            // Console.WriteLine(Courses.IndexOf("HTML5"));
            // Console.ReadLine();

            //Display list before sorting
            Courses.RemoveAt(Courses.IndexOf("HTML5"));

            foreach (string item in Courses)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Courses.IndexOf("HTML5"));
            Console.WriteLine();


            //display list AFTER sorting numerically/alphabetically
            Courses.Sort();

            foreach (string item in Courses)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();



            //using Dictionary, you NEED to have two values. the first has to be the "key"
            IDictionary<int, string> dictStudent = new Dictionary<int, string>();
            dictStudent.Add(101, "Leo");
            dictStudent.Add(102, "Jesse");
            dictStudent.Add(103, "Sam");
            dictStudent.Add(104, "Hally");

            foreach (KeyValuePair<int, string> kvp in dictStudent)
            {
                Console.WriteLine(kvp.Key + ", " + kvp.Value);
            }

            Console.ReadLine();
            Console.ReadLine();

        }



    }



    
}
