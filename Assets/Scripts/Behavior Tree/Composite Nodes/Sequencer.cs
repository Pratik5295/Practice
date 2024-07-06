using System.Collections.Generic;

public class Sequencer : Node
{
    public List<Node> Children = new List<Node>();
    public bool HasExecuted = false;

    private int currentIndex = 0;

    public void AddChild(Node node)
    {
        Children.Add(node);
    }

    public override bool Execute()
    {
        if(HasExecuted)
        {
            return false;
        }
        while(currentIndex < Children.Count)
        {
            var child  = Children[currentIndex];

            //Current child has not finished execution
            if (!child.Execute())
            {
                return false;
            }

            currentIndex++;
        }


        HasExecuted = true;
        return true;
    }
}
