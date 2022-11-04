// See https://aka.ms/new-console-template for more information

//Input a number to the ascending sorted list.

int[] arr = { 1, 2, 3, 4, 6, 7 };
int input = 5;
int p=4;

for (int i = 0; i < arr.Length; i++)
{
    if (input < arr[i])
    {
        break;
        p = i;
    }
    else
    {
        p = i + 1;
    }
}

    //saga duzmek
    for (int i = arr.Length + 1; i >= p; i--)
    {
        arr[i] = arr[i - 1];
        arr[p] = input;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }