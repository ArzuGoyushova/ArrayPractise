// See https://aka.ms/new-console-template for more information

//separate odd and even integers in separate arrays. 

using System.Globalization;

int[] arr1 = { 2, 5, 6, 8, 9 };
int[] arrOdd = new int[5];
int[] arrEven = new int[5];
int j = 0, k = 0;
for (int i=0; i<arr1.Length; i++)
{
    if (arr1[i]%2==1)
    {
        arrOdd[j] = arr1[i];
        j++;
    }
    else
    {
        arrEven[k] = arr1[i];
        k++;
    }
    
}
for (int i=0;i<j; i++)
{
    Console.WriteLine($"Odd numbers = {arrOdd[i]}");
}
for (int i=0; i<k; i++)
{
    Console.WriteLine($"Even numbers = {arrEven[i]}");
}