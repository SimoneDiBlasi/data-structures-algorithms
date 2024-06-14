namespace DataStructure
{
    public class HashTableClass(Dictionary<int, string> dictionary)
    {
        public Dictionary<int, string> HashTable { get; set; } = dictionary;

        public void Add(int key, string item)
        {
            HashTable.Add(key, item); //O(1)
        }

        public void Delete(int key)
        {
            HashTable.Remove(key); //O(1)
        }


        public void Search(int key)
        {
            HashTable.GetValueOrDefault(key, null); //O(1)
        }
    }
}
