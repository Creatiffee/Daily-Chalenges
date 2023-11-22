using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<int> nums = new List<int>();
            int b = 0;
            bool Seventeen = false;
            string input = "";
            int p = 1;
            int num = 0;

            while (input != "x") 
            {
                
                Console.WriteLine($"Give number {p} in a list of numbers to see if two added together give 17");
                input = Console.ReadLine();
                bool success = Int32.TryParse(input, out num);
                if (success)
                {
                    nums.Add(num);
                }
                else if(input == "x")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Please enter valid data");
                }
                p = p + 1;
            }

            while (b <= nums.Count - 1)
            {
                int j = 0;

                while (j <= nums.Count - 1)
                {

                    int result = nums[b] + nums[j];

                    if (result == 17)
                    {
                        Seventeen = true;
                        Console.WriteLine($"These two numbers equal seventeen : {nums[b]}+{nums[j]}");
                        break;
                    }
                    j = j + 1;

                }
                b = b + 1;
                j = 0;
            }

            Console.WriteLine("True, two numbers from the supplied list equal seventeen.");
            Console.ReadLine();
            
        }
    }
}
