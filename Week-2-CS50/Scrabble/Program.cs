class Program{
    static void Main(){
        string upperletters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowerletters = upperletters.ToLower();
        int[] Points=[1,3,3,2,1,4,2,4,1,8,5,1,3,1,1,3,10,1,1,1,1,4,4,8,4,10];


        Console.Write("Player 1: ");
        string p1response = Console.ReadLine()!;
        int Player1Points = EvalPoints(p1response);
        Console.Write("Player 2: ");
        string p2response = Console.ReadLine()!;
        int Player2Points = EvalPoints(p2response);
    }

    static int EvalPoints(string response){
        int point = 0;

        return point;
    }
}