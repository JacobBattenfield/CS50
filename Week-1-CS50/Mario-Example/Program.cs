using System.Runtime.InteropServices;

class Program{

    static void Main(){
        //Prompting end user for positive integer value for dimensions.
        int n;
        do{
            Console.Write("Dimensions: ");
            n = Convert.ToInt32(Console.ReadLine());
        }while(n<1);
        //printing a scalable brick wall
        for (int i = 0 ;i<n;i++){
            for(int j =0;j<n;j++){
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}