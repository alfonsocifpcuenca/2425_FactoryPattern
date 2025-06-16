using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyData _enemyData;

    public abstract void Attack();
    public abstract void Defense();
    public abstract void Die();
}
