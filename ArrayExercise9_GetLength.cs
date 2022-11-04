https://aka.ms/new-console-template for more information

int[,] arr = {{ 5, 8, 7 },{ 21, 1, 3 },{ 12, 2, 3 }};
int sum = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
            sum = sum + arr[i, i];
}
Console.WriteLine(sum);
	  

