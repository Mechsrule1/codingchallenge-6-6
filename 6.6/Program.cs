using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace triplets
{
    public class Class1
    {
            static void Main()
            {
                Console.WriteLine("Tell me how many lines you want to give me!");
                int N;
                int? M = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter each set of three numbers, separated by spaces and hit enter each time.");
                if (M == null)
                {
                    N = 0;
                }
                else
                {
                    N = M.Value;
                }
                List<string> triplets = new List<string>();
                for (int i = 0; i < N; i++)
                {
                    string input = Console.ReadLine();
                    triplets.AddRange(input.Split(" "));
                }
                for (int i = 0; i < N; i++ )
                {
                    int a = int.Parse(triplets[(0 + (i * 3))]);
                    int b = int.Parse(triplets[(1 + (i * 3))]);
                    int c = int.Parse(triplets[(2 + (i * 3))]);
                    int medium = 0;
                    if (a > b && a < c)
                    {
                        medium = a;
                    }
                    if (a < b && a > c)
                    {
                        medium = a;
                    }
                    if (b > a && b < c)
                    {
                        medium = b;
                    }
                    if (b < a && b > c)
                    {
                        medium = b;
                    }
                    if (c > a && c < b)
                    {
                        medium = c;
                    }
                    if (c < a && c > b)
                    {
                        medium = c;
                    }
                    Console.WriteLine(medium);
                }
            }
    }
}