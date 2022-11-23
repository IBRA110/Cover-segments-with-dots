using Segments;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {            
            int n = Convert.ToInt32(Console.ReadLine());
            
            Segment[] arr = new Segment[n];
            
            WriteDotsAndCountOfDots(arr, n);
            
        }
        
        public static void WriteDotsAndCountOfDots(Segment[] arr, int n) {

            for (int i = 0; i < n; i++)
            {
                arr[i] = new Segment(Console.ReadLine().Split());
            }

            Array.Sort(arr);
            List<int> answers = new List<int>();
            
            
            int currentPoint = -1;
            for (int i = 0; i < n; i++)
            {
                if (currentPoint < arr[i].left)
                {
                    currentPoint = arr[i].right;
                    answers.Add(currentPoint);
                }
            }
            
            Console.WriteLine(answers.Count);

            foreach (int point in answers)
            {
                Console.Write($"{point} ");
            }
        }      
    }
}
