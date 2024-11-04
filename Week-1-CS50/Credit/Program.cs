//AMEX uses 15 digit numbers starting with 34 or 37
//MASTERCARD uses 16 digit numbers starting with 51,52,53,54,55;
//VISA uses 13 digit and 16 digit numbers starting with a 4
//ALL credit cards have a checksum algorithm to determine if it is valid or nah


class Program{
    static void Main(){
        //First we need to ask the user for the number and validate that they entered a actual number, if not say invalid and ask again
        string input;
        bool isValid;
        long ccn;
        do{
            Console.Write("Number: ");
            input = Console.ReadLine()!;
            isValid = long.TryParse(input,out ccn);
        if(!isValid){
            Console.WriteLine("--------------------");
            Console.WriteLine("ERROR: NOT A NUMBER");
            Console.WriteLine("--------------------");
        }
        }while(!isValid);
        int length = GetLength(ccn);
        bool checksum = LuhnAlgorithm(ccn);
        string brand = CheckBrand(ccn,length,checksum);
        Console.WriteLine("--------------------");
        Console.WriteLine(brand);
        Console.WriteLine("--------------------");
    }
    static string CheckBrand(long number,int length,bool checksum){
        string numberstr = number.ToString();
        int firstnum = numberstr[0]-'0';
        int secondnum = numberstr[1]-'0';

        if (checksum && length == 15 && firstnum == 3 && (secondnum == 4 || secondnum == 7)) {
            return "AMEX";
        }
        if (checksum && length == 16 && firstnum == 5 && (secondnum >= 1 && secondnum <= 5)) {
            return "MASTERCARD";
        }
        if (checksum && firstnum == 4 && (length == 13 || length == 16)) {
            return "VISA";
        }
    
        return "INVALID";
}
    static int GetLength(long number){
        int length = 0;
        while(number!=0){
            number/=10;
            length++;
        }
        return length;
    }
    static bool LuhnAlgorithm(long number){
        int sum = 0;
        string numberStr = number.ToString();

        for(int i =numberStr.Length-2;i>=0;i-=2){
            int digit = (numberStr[i]-'0')*2;
            sum +=digit>9?digit-9:digit;
        }
        for(int i=numberStr.Length-1;i>=0;i-=2){
            sum +=numberStr[i]-'0';
        }
        if(sum%10==0){
            return true;
        }
        return false;
    }
}