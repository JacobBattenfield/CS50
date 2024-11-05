class Program{
    static void Main(){
    Console.Write("Height: ");
    int height = Convert.ToInt32(Console.ReadLine());
    PrintCol(height);
    }

    static void PrintCol(int height){
        for(int i=0;i<height;i++){
            Console.WriteLine("#");
        }
    }
}