class Program{
    static void Main(){
        Console.Write("Player 1: ");
        string p1response = Console.ReadLine()!;
        int Player1Points = EvalPoints(p1response);
        Console.Write("Player 2: ");
        string p2response = Console.ReadLine()!;
        int Player2Points = EvalPoints(p2response);
        Console.WriteLine($"Player One: {Player1Points} Player Two: {Player2Points}");

        if(Player1Points>Player2Points){
            Console.WriteLine("");
            Console.WriteLine("Player One Wins!");
        }else if(Player2Points>Player1Points){
            Console.WriteLine("");
            Console.WriteLine("Player Two Wins!");
        }else{
            Console.WriteLine("Error: Something Went Wrong");
        }
    }
//        int[] Points=[1,3,3,2,1,4,2,4,1,8,5,1,3,1,1,3,10,1,1,1,1,4,4,8,4,10];


    static int EvalPoints(string response){
        string upperResponse = response.ToUpper();
        int[] points =[1,3,3,2,1,4,2,4,1,8,5,1,3,1,1,3,10,1,1,1,1,4,4,8,4,10];
        int sum = 0;

        for(int i =0;i<upperResponse.Length;i++){
            int index = upperResponse[i]-'A';
            if(index>=0&&index<=points.Length){
            sum+=points[index];
            }
        }
        return sum;
    }
}