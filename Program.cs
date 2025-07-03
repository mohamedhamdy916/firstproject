namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter number of small carpet :");
            int smallcarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number of large carpet :");
            int largecarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" price per small room : $25");
            Console.WriteLine(" price per large room : $35");
            Console.WriteLine($"cost : {smallcarpet * 25 + largecarpet * 35}");
            int cost = Convert.ToInt32(smallcarpet * 25 + largecarpet * 35);
            double Tax = Convert.ToDouble(.06 * cost);
            Console.WriteLine($"Tax = $ {Tax}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Total estimate : {cost + Tax}");
            Console.WriteLine("This estimate is valid for 30 days");

        }
        
    }
}
