using KrazyKrakenGames.Practice.BehaviorTree;
using UnityEngine;

/// <summary>
/// This is a test Leaf Node, so we just use it for debugging purpose
/// </summary>
public class Leaf : Node
{
    private IStrategy strategy;
    public Leaf(IStrategy _strategy)
    {
       strategy = _strategy;
    }

    public override bool Execute()
    {
        //After executtion
        return strategy.Process();
    }
}
