int[] array = new int[5] { 1, 2, 3, 4, 5 };
int m = 1;
void ReversePrint(int[] array, int m)
{

    System.Console.WriteLine(array[(array.Length) - m]);
    if (m != array.Length)
    {
        ReversePrint(array, m + 1);
    }
}
ReversePrint(array, m);