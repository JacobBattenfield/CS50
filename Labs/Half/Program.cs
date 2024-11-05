
class Program{
    static void Main(){
        Console.Write("Bill before tax and tip: ");
        double bill = Convert.ToDouble(Console.ReadLine());
        Console.Write("Sales Tax Percent: ");
        double tax = Convert.ToDouble(Console.ReadLine());
        Console.Write("Tip Percent: ");
        double tip = Convert.ToDouble(Console.ReadLine());
        Console.Write("People Sharing Bill: ");
        double people = Convert.ToDouble(Console.ReadLine());

        double AmountPerPerson = CalculateAmountOwed(bill,tax,tip,people);
        Console.WriteLine($"You will owe {AmountPerPerson} each!");


    }

    static double CalculateAmountOwed(double gross, double tax, double tip,double people){
        double taxAmount = gross * (tax/100);
        double tipAmount = gross * (tip/100);
        double totalAmount = gross + taxAmount + tipAmount;

        double amountPerPerson = totalAmount/people;

        return Math.Round(amountPerPerson,2);
    }
}