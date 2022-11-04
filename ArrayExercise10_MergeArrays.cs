// See https://aka.ms/new-console-template for more information

int[] arr1 = { 1, 3, 8, 9 };
int[] arr2 = { 2, 7, 12, 13 };
int[] arr3 = new int[8];
int i, j, k;

for (i = 0; i < arr1.Length; i++)
{
    arr3[i] = arr1[i];
}
for (j = 0; j < arr2.Length; j++)
{
    arr3[i] = arr2[j];
    i++;
}
for (i = 0; i < arr3.Length; i++)
{
    for (k = i+1; k < arr3.Length; k++)
    {
        if (arr3[k] < arr3[i])
        {
            j = arr3[i];
            arr3[i] = arr3[k];
            arr3[k] = j;
        }
    }
}
for (i=0; i < arr3.Length; i++)
{
    Console.WriteLine(arr3[i]);
}
