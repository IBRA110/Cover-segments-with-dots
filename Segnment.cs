namespace Segments{
    public struct Segment: IComparable<Segment>
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

