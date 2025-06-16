

using UnityEngine;

public class General : Enemy
{
    public override void Attack()
    {
        Debug.Log("General Attack");
    }

    public override void Defense()
    {
        Debug.Log("General Defense");
    }

    public override void Die()
    {
        Debug.Log("General Die");
    }
}
