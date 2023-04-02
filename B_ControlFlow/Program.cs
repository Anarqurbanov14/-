namespace B_ControlFlow;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Fibonacci numbers you want to generate");
        int n = int.Parse(Console.ReadLine());

        int[] fibonacci = new int[n];

        int a0 = 0;
        int a1 = 1;

        fibonacci[0] = a0;
        fibonacci[1] = a1;

        for(int i = 2;i < n; i++)
        {
            int a = a0 + a1;
            fibonacci[i] = a;

            a0 = a1;
            a1 = a;

        }

        foreach(int cur in fibonacci)
        {
            Console.WriteLine(cur);
        }
        Console.ReadLine();


    }       
}

