// See https://aka.ms/new-console-template for more information

int i, j, cnt;
int[] arr = {2,4,2,5,5,6};
int[] freq = new int[6];

for (i = 0; i < arr.Length; i++)
{
    freq[i] = -1;
}
for (i = 0; i < arr.Length; i++)
{
    cnt = 1;
    for (j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            cnt++;
            freq[j] = 0;
        }
    }
    if (freq[i] != 0)
    {
        freq[i] = cnt;
    }
}
Console.WriteLine("Duplicate and Unique Numbers in Array :");
for (i = 0; i < arr.Length; i++)
{
    if (freq[i] != 0)
    {
        Console.WriteLine("Number " + arr[i] + " Occur " + freq[i] + " Times");
    }
}