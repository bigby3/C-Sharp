namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sayı=");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayı=");
            int y = Convert.ToInt32(Console.ReadLine());
            int toplam = x + y;
            Console.WriteLine("Toplam=" + toplam);
            Console.ReadLine();
        
        }
    }
}
