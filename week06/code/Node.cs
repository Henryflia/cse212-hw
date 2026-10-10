public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if(Data == value)
        {
            return;
        }
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (Data == value)
        {
            return true;
        }

        bool left = Left != null && Left.Contains(value);
        bool right = Right != null && Right.Contains(value);
        return left || right;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int l = 0;
        int r = 0;

        if (Left != null)
        {
            l = Left.GetHeight();
        }

        if (Right != null)
        {
            r = Right.GetHeight();
        }

        return 1 + Math.Max(l, r);
    }
}