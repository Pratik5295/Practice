using UnityEngine;

namespace KrazyKrakenGames.Practice.BehaviorTree
{
    public class BehaviorTree: MonoBehaviour
    {
        //PSEUDO:
        //A tree is made of nodes, we will be using Leaf

        Node root;

        [SerializeField] private Transform entity;
        [SerializeField] private Transform target;

        private void Start()
        {
            root = new Sequencer();

            Sequencer sequencer = new Sequencer();
            sequencer.AddChild(new Leaf(new TestStrategy("Hello World")));
            sequencer.AddChild(new Leaf(new TestStrategy("Hello Gamer!")));

            Leaf moveToTarget = new Leaf(new MoveTowardsStrategy(entity, target));
            sequencer.AddChild(moveToTarget);


            ((Sequencer)root).AddChild(sequencer);

            
        }

        private void Update()
        {
            root.Execute();
        }
    }
}
