using System.Runtime.CompilerServices;

class Program{
    static void Main(){
        Console.Write("Number of weeks taking CS50: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int[] weeks = new int[input];
        for(int i = 0 ;i <weeks.Length;i++){
            Console.Write($"Week {i} HW Hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            weeks[i]=hours;
        }
        string response;
        do{
        Console.Write("Enter T for total hours, Enter A for average, Ender Q to quit: ");
         response = Console.ReadLine()!.ToUpper();
         if(response == "T"){
            int sum=0;
            for(int i = 0 ;i < weeks.Length;i++){
               sum += weeks[i];
            }
            Console.WriteLine($"Total: {sum}");
         }else if(response =="A"){
            double sum = 0;
            for(int i = 0;i<weeks.Length;i++){
                sum+=weeks[i];
            }
            double ave=Math.Round((double)(sum/weeks.Length),1);
            Console.WriteLine($"Avergae: {ave}");

         }
        }while(response!="Q");
        
    }
}