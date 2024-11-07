using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program{

    //Gather User Input And Run PrintPrimes
    static void Main(){
        Console.Write("Minimum: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Maximum: ");
        int max = Convert.ToInt32(Console.ReadLine());

        PrintPrimes(min,max);
    }
    //If The Number Is Prime, Print It
    static void PrintPrimes(int floor, int ceil){
        for(int i = floor;i<=ceil;i++){
            if(TestPrime(i)){
                Console.WriteLine(i);
            }
        }
    }
    //Tests If A Number Is Prime With Three Validation Gates
    static bool TestPrime (int num){
        bool validation1 = num>1;
        bool validation2 = num==2;
        bool validation3 = true;

        for(int i = 2;i<num;i++){
            if(num%i==0){
                validation3=false;
                break;
            }
        }

        if((validation1&&validation3)||validation2){
            return true;
        }
        return false;
    }
}