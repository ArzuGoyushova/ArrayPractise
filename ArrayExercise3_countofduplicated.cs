// See https://aka.ms/new-console-template for more information

//Total number of duplicate elements.

int[] nums = { 1, 3, 1, 5, 7, 7, 9, 9 };
int[] nums2 = new int[10];
int[] nums3 = new int[10];
int count=0, mark = 0;

for (int i=0; i<nums.Length; i++)
{
    nums2[i] = nums[i];
    
}
for (int i=0; i<nums.Length; i++)
{
    for (int j=0; j<nums.Length; j++)
    {
        if (nums[i] == nums2[j])
        {
            nums3[j] = mark;
            mark++;
        }
    }
    mark = 1;
}
for (int i=0; i<nums.Length; i++)
{
    if (nums3[i] == 2)
    {
        count++;
    }
}
Console.WriteLine(count);
