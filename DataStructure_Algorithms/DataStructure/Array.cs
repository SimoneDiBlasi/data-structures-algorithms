namespace DataStructure
{
    public class ArrayClass(int[] array)
    {
        public int[] Array { get; set; } = array;

        public int Find(int index) // O(1)
        {
            return Array[index];
        }

        public void Print() // O(n)
        {
            Console.WriteLine(Array);
        }

        public int Max() // O(n)
        {
            return Array.Max();
        }

        public int[] Reverse() // O(n)
        {
            return Array.Reverse().ToArray();
        }
    }
}
