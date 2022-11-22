

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {            
            int n = Convert.ToInt32(Console.ReadLine());
            
            Segment[] arr = new Segment[n];
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = new Segment(Console.ReadLine().Split());
            }
            
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i].left.ToString() + " ");
                Console.Write(arr[i].right.ToString() + " ");
                Console.WriteLine();
            }
        }
        struct Segment: IComparable<Segment>
        {
            public int left;
            public int right;

            public Segment(string[] str)
            {
                left = int.Parse(str[0]);
                right = int.Parse(str[1]);
            }

            public int CompareTo(Segment other)
            {
                return right.CompareTo(other.right);
            }

            public override string ToString()
            {
                return $"[{left}, {right}]";
            }
        }      
    }
}
