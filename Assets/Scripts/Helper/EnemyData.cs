using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "CIFP/EnemyData")]
public class EnemyData : ScriptableObject
{
    public EnemyType type;
    public GameObject prefab;
}