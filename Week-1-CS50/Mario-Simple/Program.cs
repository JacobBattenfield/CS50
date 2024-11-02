class Program{
    static void Main(){
        int height;
        //Making the Program Scaleable
        do{
        Console.Write("Height: ");
        height = Convert.ToInt32(Console.ReadLine());
        }while(height<0||height>8);

        //Building blocks of the pyramid
        string bricks = "";
        string space = "";

        //program runs while the pyramids height is above 0
        while(height>0){
            //reset space and add to bricks every iteration
            space = "";
            bricks+="#";
            //increase space proportionate to our bricks
            for(int i = 0;i<height;i++){
                space+=" ";
            }
            //interpolation to print out our pyramid
           Console.WriteLine($"{space}{bricks}");
           //decrement the hight after every iteration
           height--;
        }
    }
}