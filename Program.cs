using System;

namespace While_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int a = 0;
            //while(a<3)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}

            //do
            //{
            //    a++;
            //    Console.WriteLine(a);

            //} while (a <= 5);


            //Console.WriteLine(a++); //PostIncrement
            //Console.WriteLine(++a); //PreIcrement
            //Console.WriteLine(a+=3); //inc then print >>> a=a+3
            //Console.WriteLine(a=+3); // print then inc >>> a=a+3

            //Console.Write("Enter First ODD Number: ");
            //int firstNo = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second ODD Number: ");
            //int secondNo = int.Parse(Console.ReadLine());


            //    for (int i = firstNo; i<= secondNo; i+=2)
            //    {
            //        Console.WriteLine(i);
            //    }
                float j = 1;
                int n1 = int.Parse(Console.ReadLine());
                if (n1<0)
            {
                Console.WriteLine("Number must be non negative.");
            }
                else if (n1==0 || n1==1) {
                Console.WriteLine("The factorial of "+ n1+ " is: 1"); 
            }
            
                else if(n1>1) {
                    for(int i = 2; i<=n1; i++)
                {
                    j *= i; 
                }
                Console.WriteLine("The factorial of " + n1 + " is: " + j);
            }
        }
    }
}