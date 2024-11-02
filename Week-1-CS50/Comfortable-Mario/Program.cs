class Program{
    static void Main(){
        int height;
        do{Console.Write("Height: ");
        string input = Console.ReadLine()!;
        height = int.TryParse(input, out int parsedHeight) ? parsedHeight : -1;
        } while (height < 1 || height > 8);
        string spaces = "";
        string bricks = "";
        string gap = "  ";
        while(height>0){
            
            spaces="";
            bricks+="#";
            for(int i = 0;i<height;i++){
                spaces+=" ";
            }
            Console.WriteLine($"{spaces}{bricks}{gap}{bricks}");
            height--;
        }
    }
}