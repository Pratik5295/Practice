using UnityEngine;

namespace KrazyKrakenGames.Practice.BehaviorTree
{
    /// <summary>
    /// This is a debugging strategy, just created for learning purpose
    /// </summary>
    public class TestStrategy : IStrategy
    {
        public string message;

        public TestStrategy(string message = "Default message")
        {
            this.message = message;
        }

        public bool Process()
        {
            Debug.Log($"Strategy executed:{message}");

            return true;
        }

    }
}
