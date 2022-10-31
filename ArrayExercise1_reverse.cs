// See https://aka.ms/new-console-template for more information

//Print array elements in reverse order

int[] nums = { 1, 3, 6, 4, 5, 7, 9 };
int[] numsReversed = new int[10]; 


for (int i = nums.Length-1; i>=0; i--)
{
    numsReversed[i] = nums[i];

    Console.WriteLine(numsReversed[i]);
}
