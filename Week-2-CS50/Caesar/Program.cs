using System.Security.Permissions;

class Program{
    static void Main(string[] args){
        if(args.Length ==1 &&int.TryParse(args[0],out int key)&&key>0){
            Console.Write("plaintext: ");
            string plaintext = Console.ReadLine()!;
            Ceasar(key,plaintext);
            Console.Write("ciphertext: ");
        }else{
            
            Console.WriteLine("Usage: dotnet run {key}");
        }
    }
    static string Ceasar(int rot,string text){
        
        string ciphertext="";



        return ciphertext;
    }
}