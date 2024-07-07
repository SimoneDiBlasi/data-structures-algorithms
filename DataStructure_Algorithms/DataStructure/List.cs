namespace DataStructure
{
    public class ListClass(List<int> list)
    {
        public List<int> List { get; set; } = list;
        public LinkedList<int> LinkedList { get; set; }
        public SortedList<int, int> SortedList { get; set; }

        public void Add(int item)
        {
            SortedList.Add(1, 3); // O(n)
            LinkedList.AddLast(item); // O(1)
            List.Add(item); // O(1)
        }

        public void Delete(int item)
        {
            SortedList.Remove(3); //O(logn)
            LinkedList.Remove(item);  // O(n)
            List.Remove(item); // O(n)
        }


        public void Search(int item)
        {
            List.FirstOrDefault(val => val == item); // O(n) 
            SortedList.FirstOrDefault(val => val.Key == 5); // O(n) 
            LinkedList.FirstOrDefault(item); // O(n) 
        }


    }

}
