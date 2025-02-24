namespace Task1_Erasoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service");

            Console.WriteLine("Enter number of small carpets : ");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of large carpets : ");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());

            int priceSmall = 25;
            int priceLarge = 35;

            Console.WriteLine($"Price per samll room : {priceSmall}");
            Console.WriteLine($"Price per large room : {priceLarge}");

            int cost = 0;
            cost = (smallCarpets * priceSmall) + (largeCarpets * priceLarge);
            Console.WriteLine($"Cost : {cost}");

            double tax = 0.06;
            double taxRate = cost * tax;
            Console.WriteLine($"tax : {taxRate}");
            Console.WriteLine("================================");
            double totalEstimate = cost + taxRate;

            Console.WriteLine($"Total estimate : {totalEstimate}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
