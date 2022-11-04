// See https://aka.ms/new-console-template for more information

int[] arr = { 1, 2, 4, 6, 7, 9 };
int i, j=0;
int lrg = arr[0];
int lrg2 = arr[0];

for (i = 0; i < arr.Length; i++)
{
    if (lrg < arr[i])
    {
        lrg = arr[i];
        j = i;
    }
}
for (i = 0; i < arr.Length; i++)
{
    if (i == j)
    {
        i++;
        i--;
    }
    else
    {
        if (lrg2 < arr[i])
        {
            lrg2 = arr[i];
        }
    }
}
Console.WriteLine(lrg2);