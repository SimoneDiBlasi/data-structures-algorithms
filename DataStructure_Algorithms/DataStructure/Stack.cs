namespace DataStructure
{
    public class StackClass(Stack<int> stack)
    {
        // Stack(LIFO) -> Solitamanete ultizzati per algoritmi di backtracking -> Ti permette di tornare indietro tramire 
        public Stack<int> Stack { get; set; } = stack;

        public void Add(int item)
        {
            Stack.Push(item); //O(1)
        }

        public void Delete()
        {
            Stack.Pop();  //O(1)
        }


        public void Peek()
        {
            Stack.Peek(); //O(1)
        }
    }
}
