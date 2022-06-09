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
                
                
                Console.WriteLine("Enter each line you want me to find the total of.");
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
                    triplets.Add(Console.ReadLine());
                }
                for (int i = 0; i < N; i ++)
                {
                char digit;
                bool result;
                string line = triplets[i];
                int total = 0;
                    for (int j = 0; j < line.Length; j++)
                    {
                        digit = line[j];
                        result = Char.IsDigit(digit);
                        if (result == true)
                        {
                            total = total + (int)digit - '0';
                        }
                    }
                    Console.WriteLine(total);
                }
                 
                
            }
    }
}
