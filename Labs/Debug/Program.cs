class Program{
    static void Main(){
        Console.Write("What is your name? ");
        string name = Console.ReadLine()!;
        Console.Write("Where do you live? ");
        string place = Console.ReadLine()!;
        Console.WriteLine($"Hello, {name}, from {place}!");
    }
}