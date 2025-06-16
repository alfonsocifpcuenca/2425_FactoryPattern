using UnityEngine;

public class Lieutenant : Enemy
{
    public override void Attack()
    {
        Debug.Log("Lieutenant Attack");
    }

    public override void Defense()
    {
        Debug.Log("Lieutenant Defense");
    }

    public override void Die()
    {
        Debug.Log("Lieutenant Die");
    }
}
