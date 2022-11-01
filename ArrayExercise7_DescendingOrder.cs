// See https://aka.ms/new-console-template for more information
//Descending order.

using System.Globalization;

int[] arr = { 5, 9, 4, 2, 3, 12 };
int temp;

for (int i = 0; i < arr.Length; i++)
{
    for (int j=i+1; j<arr.Length; j++)
    {
        if (arr[j] > arr[i])
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
