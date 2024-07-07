namespace DataStructure
{
    public class QueueClass(Queue<int> queue)
    {
        // Queue(FIFO)
        public Queue<int> Queue { get; set; } = queue;
        public PriorityQueue<int, int> PriorityQueue { get; set; }

        public void Add(int item)
        {
            Queue.Enqueue(item); //O(1)
            PriorityQueue.Enqueue(item, 2);
        }

        public void Delete()
        {
            Queue.Dequeue();  //O(1)
            PriorityQueue.Dequeue();
        }


        public void Peek()
        {
            Queue.Peek(); //O(1)
            PriorityQueue.Peek();
        }
    }
}
