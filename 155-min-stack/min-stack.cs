public class MinStack
{
    private Stack<int> mainStack;
    private Stack<int> minStack;

    public MinStack()
    {
        mainStack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        mainStack.Push(val);

        // If minStack is empty or val <= current min, push it
        if (minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
        else
        {
            // Push the same current min again to keep stacks in sync
            minStack.Push(minStack.Peek());
        }
    }

    public void Pop()
    {
        if (mainStack.Count > 0)
        {
            mainStack.Pop();
            minStack.Pop();
        }
    }

    public int Top()
    {
        return mainStack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}
