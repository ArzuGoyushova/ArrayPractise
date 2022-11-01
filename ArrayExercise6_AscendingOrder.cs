// See https://aka.ms/new-console-template for more information

//Ascending Order.

int[] arr1 = { 5, 2, 4, 3, 7 };
int temp;

for (int i = 0; i < arr1.Length; i++)
{
    for (int j = i+1; j < arr1.Length; j++)
    {
        if (arr1[j] < arr1[i])
        {
            temp = arr1[i];
            arr1[i] = arr1[j];
            arr1[j] = temp;
        }
    }
}
for (int i = 0; i < arr1.Length; i++)
{
    Console.WriteLine(arr1[i]);
}
