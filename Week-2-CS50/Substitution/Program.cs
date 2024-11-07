
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Program{
    static void Main(string[] args){
    
        if(args.Length!=1){
            Console.WriteLine("Please enter a valid, unique, capital 26 letter key");
        }else{
            if(EvaluateKey(args[0])){
                Console.Write("plaintext: ");
                string text = Console.ReadLine()!;
                string substitute = Substitute(args[0],text);
                Console.Write($"ciphertext: {substitute}");
            }
        }
    }
    static string Substitute(string key,string text){
        string ciphertext="";

        for(int i = 0 ;i<text.Length;i++){
            char c = text[i];
            char offset = char.IsUpper(c) ? 'A':'a';
            if(char.IsLetter(c)){
                int index = c-offset;
                c=char.IsUpper(c)?key[index]:char.ToLower(key[index]);
                ciphertext+=c;
            }else{
                ciphertext+=c;
            }
        }
        return ciphertext;
    }
    static bool EvaluateKey(string key){
        
        HashSet<char> SeenLetters = [];
        for(int i = 0 ;i<key.Length;i++){
            if(SeenLetters.Contains(key[i])){
                Console.WriteLine("Error, Duplicate Found");
                return false;
            }
            SeenLetters.Add(key[i]);
        }
        if(key.Length!=26){
            Console.WriteLine("Error, Key Length Not 26");
            return false;
        }
        foreach(char c in key){
            if(char.IsDigit(c)){
                Console.WriteLine("Error, Number Found In Key");
                return false;
            }
        }
        foreach(char c in key){
            if(char.IsLower(c)){
                Console.WriteLine("Error, Lowercase Detected");
                return false;
            }
        }
        return true;
    }
}