// See https://aka.ms/new-console-template for more information

//Find max and min in array

int[] arr = { 2, 7, 8, 12, 3, 16, 5 };
int max = arr[0];
int min = arr[0];

for(int i = 0; i < arr.Length; i++)
{
    if (max < arr[i])
    {
        max= arr[i];
    }
    if (min > arr[i])
    {
        min = arr[i];
    }
}
Console.WriteLine(max);
Console.WriteLine(min);