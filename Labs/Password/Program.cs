using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;

class Program{
    static void Main(){
        Console.Write("Enter A Password: ");
        string Password = Console.ReadLine()!;
        bool IsSecure = ValidatePassword(Password);
        if(IsSecure){
            Console.WriteLine("Your password is valid!");
        }else{
            Console.WriteLine("Your password needs the following: an uppercase letter, lowercase letter, number, symbol, eight characters or more and one word only.");
        }
    }
    static bool ValidatePassword(string pass){
        char[] specials = ['!','#','$','%','^','&','*','(',')','?'];
        char[] digits = ['1','2','3','4','5','6','7','8','9','0'];
        char[] upper = new char[26];
        char[] lower = new char[26];
        int uletter = 65;
        int lletter = 97;
        for(int i = 0;i<upper.Length;i++){
            upper[i]=(char)uletter;
            lower[i]=(char)lletter;
            uletter++;lletter++;
        }
        if(pass.Length<8){
            return false;
        }
        if(pass.IndexOfAny(specials)==-1){
            return false;
        }
        if(pass.IndexOfAny(digits)==-1){
            return false;
        }
        if(pass.IndexOfAny(upper)==-1){
            return false;
        }
        if(pass.IndexOfAny(lower)==-1){
            return false;
        }
        for(int i = 0;i<pass.Length;i++){
            if(pass[i]==' '){
                return false;
            }
        }
        return true;
    }
}