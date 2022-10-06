Console.WriteLine("Add numbers M");
int[] ArrayNumbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < ArrayNumbers.Length; i++)
{
    if (ArrayNumbers[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($" Количество чисел > 0:= {count}");
