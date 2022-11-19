namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type numbers");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
