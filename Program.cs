
using Faker;
internal class Program
{
    private static void Main(string[] args)
    {
        var random = new Random();
        for(int i = 1; i <= 3; i++)
        {
        var name = Name.FullName(NameFormats.WithPrefix);
        var city = Address.City();
        var idNumber = RandomNumber.Next(100000000);
        var character = Convert.ToChar(random.Next('A','Z'));
        Console.WriteLine($"Hello, {name} ID {character} {idNumber} from {city}!");
        }
    }
}