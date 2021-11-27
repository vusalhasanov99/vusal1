using System;

namespace vusal2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string sum1 = Sum(5, 6, "Vusal");
            string sum2 = Sum(7, 8, "Rovshan");
            string result = sum1 + sum2;
            // Console.WriteLine(result);
            // Read(3, 4);
            
            
            string[] names = { "vusal", "Rovshan", "Orxan" };
           var age = Age(10, 8);
            int endAge = age + 5;
            Console.WriteLine(endAge);
        }



        static string  Sum(int n, int m, string name)
        {
            int num2 = 8;
            int sum = n + m + num2;
            
            
            return sum+name;
        }
        static void Read(int a, int b)
        {




        }

        
        static int Age(int a, int b)

        {
        int sumAge = a + b;
        return sumAge;
        }

        static void CheckName(string[] students)
        {
            for (int i = 0; i < students.length; i++)
            {
                Console.WriteLine(students[i]);

            }


            //foreach(var item in students)
        }
    }

}

