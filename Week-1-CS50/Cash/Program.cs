
class Program{
    static void Main(){
        int amount;
        do{
        Console.Write("Change Owed: ");
         amount = Convert.ToInt32(Console.ReadLine());
        }while(amount<0);
        Console.WriteLine($"Coins Returned: {FindChange(amount)}");
    }

    static int FindChange(int change){
        int coins = 0;
        int[] values = [25,10,5,1];
        do{
            for(int i = 0 ;i<values.Length;i++){
                while(change>=values[i]){
                    change-=values[i];
                    coins++;
                }
            }
        }while(change>0);
        return coins;
    }
}
