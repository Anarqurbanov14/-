using System.Text;

namespace CSharpKurs;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ukajite Imya");
        string name = Console.ReadLine();
        Console.WriteLine("ukajite vozrast");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Napiwite familiyu");
        string userName = Console.ReadLine();




        string total =
            $"Spasibo Mr. :{Environment.NewLine}"
           + $"Vawe imya: {name}{Environment.NewLine}"
           + $"Vaws Familiya :{userName}{Environment.NewLine}"
        +$"Vaw vozrast:{age}{Environment.NewLine}";
        Console.WriteLine(total);
    }
}






