using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int b = 0;
            string input = "";
            int p = 1;
            int num = 0;
            int result = 0;

            while (input != "x")
            {

                Console.WriteLine($"Give number {p} of an amount numbers to find the product of those numbers without the number currently in rotation, press x to stop adding.");
                input = Console.ReadLine();
                bool success = Int32.TryParse(input, out num);
                if (success)
                {
                    nums.Add(num);
                }
                else if (input == "x")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Please enter valid data");
                }
                p = p + 1;
            }

            List<int>numRes = new List<int>();

            foreach(int q in nums) 
            { 
            result = ProductNum(b, nums);
            numRes.Add(result);
            b = b + 1;
            }
            
            //result2 = ProductNum(b, nums);
            //numRes.Add(result2);
            //b = b + 1;
            //result3 = ProductNum(b, nums);
            //numRes.Add(result3);
            //b = b + 1;
            //result4 = ProductNum(b, nums);
            //numRes.Add(result4);
            //b = b + 1;
            //result5 = ProductNum(b, nums);
            //numRes.Add(result5);

            Console.WriteLine(string.Join("\t", numRes));
            Console.ReadLine();
        }

        public static int ProductNum(int i, List<int>nums)
        {

            List<int> methodNums = new List<int>();
            int m = 0;

            foreach(int c in nums)
            {
                methodNums.Add(nums[m]);
                m = m + 1;
            }

            methodNums[i] = 1;
            int result = 0;

            //result = methodNums[0] * methodNums[1] * methodNums[2] * methodNums[3] * methodNums[4];
            result = methodNums[0];
            int p = 1;
            
           while (p < methodNums.Count) 
           { 
             result = result * methodNums[p];
             p = p + 1;
           }     
            
            return result;
        }
    }
}
