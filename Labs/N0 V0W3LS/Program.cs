class Program{
    static void Main(string[] args){
        if(args.Length==1&&VerifyInput(args[0])){
            Console.Write($"No-Vowel: {Replace(args[0])}");
        }
        else{
            Console.WriteLine("Proper Usage: dotnet run '{word}'");
        }
    }
    static string Replace(string word){
        string noVowel= "";
        for(int i = 0 ;i < word.Length;i++){
            char c = word[i];
            switch(c){
                case 'a':
                case 'A':
                c='6';
                break;
                case 'e':
                case 'E':
                c='3';
                break;
                case 'i':
                case 'I':
                c='1';
                break;
                case 'o':
                case 'O':
                c='0';
                break;
            }
            noVowel+=c;
        }
        return noVowel;
    }
    static bool VerifyInput(string word){
        if(word==""){
            return false;
        }
        for(int i = 0;i<word.Length;i++){
            char c = word[i];
            if(char.IsDigit(c)){
                return false;
            }
        }
        return true;
    }
}