// See https://aka.ms/new-console-template for more information

//copy from 1 array to another

int[] arr1 = { 1, 3, 5, 9 };
int[] arr2 = new int[10];

for (int i = 0; i < arr1.Length; i++)
{
    arr2[i] = arr1[i];
    Console.WriteLine($"Array {i} element is = {arr2[i]}");
}