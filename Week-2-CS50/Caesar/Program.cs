using System.Security.Permissions;

class Program{
    static void Main(string[] args){
        if(args.Length ==1 &&int.TryParse(args[0],out int key)&&key>0){
            Console.Write("plaintext: ");
            string plaintext = Console.ReadLine()!;
            string ciphertext =Ceasar(key,plaintext);
            Console.Write($"ciphertext: {ciphertext}");
        }else{
            
            Console.WriteLine("Usage: dotnet run {key}");
        }
    }
    static string Ceasar(int key,string text){
        string ciphertext="";
        for(int i = 0 ; i < text.Length;i++){
            char c = text[i];
            if(char.IsLetter(c)){
                char offset = char.IsUpper(c) ? 'A':'a';
                ciphertext+=(char)((c+key-offset)%26+offset);
            }
        }
        return ciphertext;
    }
}