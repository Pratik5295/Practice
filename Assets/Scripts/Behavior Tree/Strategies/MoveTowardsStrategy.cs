using KrazyKrakenGames.Practice.BehaviorTree;
using UnityEngine;

public class MoveTowardsStrategy : IStrategy
{
    private Transform entity;
    private Transform target;

    public float range;

    public MoveTowardsStrategy(Transform entity, Transform target, float range = 3f)
    {
        this.entity = entity;
        this.target = target;
        this.range = range;
    }

    public bool Process()
    {
        entity.position = Vector3.MoveTowards(entity.position, target.position, 5f * Time.deltaTime);
        
        if(Vector3.Distance(entity.position, target.position) < range)
        {
            Debug.Log("Move Towards Strategy completely executed");
            return true;
        }

        return false;
    }
}
