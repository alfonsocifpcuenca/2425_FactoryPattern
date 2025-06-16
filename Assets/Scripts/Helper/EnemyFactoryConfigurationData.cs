using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CIFP/Enemy Factory Configuration")]
public class EnemyFactoryConfigurationData : ScriptableObject
{
    public List<EnemyData> enemyDatas = new List<EnemyData>();
    
}