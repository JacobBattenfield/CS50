using System.Reflection.Metadata;

class Program{
    static void Main(){
        Console.Write("How Many Scores: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] scores = new int[n];
        int sum = 0;

        for(int i = 0; i < n; i++){
            Console.Write($"Score {i+1}: ");
            scores[i]=Convert.ToInt32(Console.ReadLine());
            sum+=scores[i];
        }
        Console.WriteLine($"Average: {sum/(float)n}");
        
    }
}