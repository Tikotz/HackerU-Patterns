using HM_Adapter;


class program
{
    static void Main(string[] args)
    {
        PaymentInDollar adapter1 = new ConvertDollarToEuro();
        int intx = new Random().Next(10);

        PaymentMethod(adapter1, intx);

    }

    public static void PaymentMethod(PaymentInDollar swich, double x)
    {
        Console.WriteLine(swich.DollarPayment(x));
    }

}
