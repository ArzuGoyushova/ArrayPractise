using System;

namespace Array
{
    //1.Verilmish array-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 16, 2, 96, 10, 66 };
            int mult = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]>=1 && nums[i] <= 20)
                {
                    mult *= nums[i];
                }
            }
            Console.WriteLine($"Multipication of the requeried numbers is = {mult}");
        }
    }
}