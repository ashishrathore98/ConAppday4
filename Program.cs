
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace ConAppday3
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                ////(condition)  ?true case :false case
                //int num1, num2;
                //Console.WriteLine("Enter First Number");
                //num1=int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter Second Number");
                //num2 = int.Parse(Console.ReadLine());
                //var result = num1 > num2 ? "First Number is greater" : "Second Number is greater";
                //Console.WriteLine(result);
                //Console.ReadKey();

                //Console.WriteLine("Current Season is : " + Seasons.rainy);
                //Console.WriteLine("Season Number is : \t  " + (int)Seasons.rainy);
                //Console.ReadKey();

                // Ques for self, given in class..
                Console.WriteLine("Enter marks obtained in Pre:");
                int preMarks = int.Parse(Console.ReadLine());

                if (preMarks > 60)
                {
                    Console.WriteLine("Enter marks obtained in Finals:");
                    int finalMarks = int.Parse(Console.ReadLine());

                    if (finalMarks > 55)
                    {
                        Console.WriteLine("Selected");
                    }
                    else
                    {
                        Console.WriteLine("Fail in Finals");
                    }
                }
                else
                {
                    Console.WriteLine("Fail in Pre");
                }

                Console.ReadLine();

            }
        }
    }

