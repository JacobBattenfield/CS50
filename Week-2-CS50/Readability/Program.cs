
class Program{
    static void Main(){
        Console.Write("Text: ");
        string text = Console.ReadLine()!;
        int letters = CountLetters(text);
        int words = CountWords(text);
        int sentences = CountSentences(text);
        int readability = ComputeIndex(letters,words,sentences);
        if(readability<1){
            Console.WriteLine($"Before Grade {1}");
        }else if(readability>=1&&readability<=16){
            Console.WriteLine($"Grade: {readability}");
        }else if(readability>16){
            Console.WriteLine($"Grade: {16}+");
        }
    }
    static int CountLetters(string text){
        string uppertext = text.ToUpper();
        int letters = 0;
        for(int i = 0;i<uppertext.Length;i++){
            if(uppertext[i]>=65&&uppertext[i]<=90){
                letters++;
            }
        }
        return letters;
    }
    static int CountWords(string text){
        int words = 1;
        for(int i = 0;i<text.Length;i++){
            if(text[i]==32){
                words++;
            }
        }
        return words;
    }
    static int CountSentences(string text){
        int sentences = 0;
        for(int i = 0;i<text.Length;i++){
            if(text[i]==33||text[i]==46||text[i]==63){
                sentences++;
            }
        }
        return sentences;
    }
    static int ComputeIndex(int lettercount, int wordcount, int sentencecount){
        double L = (double)lettercount/wordcount*100;
        double S = (double)sentencecount/wordcount*100;
        double index = Math.Round(0.0588 * L - 0.296 * S - 15.8);

        return (int)index;
    }
}