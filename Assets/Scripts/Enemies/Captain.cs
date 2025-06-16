using UnityEngine;

public class Captain : Enemy
{
    public override void Attack()
    {
        Debug.Log("Captain Attack");
    }

    public override void Defense()
    {
        Debug.Log("Captain Defense");
    }

    public override void Die()
    {
        Debug.Log("Captain Die");
    }
}
