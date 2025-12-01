class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, };
        int sum=0;

        foreach (int num in arr)
        {
            sum = sum + num;

        }
        Console.WriteLine(sum);
    }
}