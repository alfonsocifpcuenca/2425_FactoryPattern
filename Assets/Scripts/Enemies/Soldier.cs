using UnityEngine;

public class Soldier : Enemy
{
    public override void Attack()
    {
        Debug.Log("Soldier Attack");
    }

    public override void Defense()
    {
        Debug.Log("Soldier Defense");
    }

    public override void Die()
    {
        Debug.Log("Soldier Die");
    }
}
