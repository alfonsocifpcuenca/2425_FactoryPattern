using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory
{
    private EnemyFactoryConfigurationData _enemyFactoryConfigurationData;
    private Dictionary<EnemyType, GameObject> _enemiesDictionary = new Dictionary<EnemyType, GameObject>();

    public EnemyFactory(EnemyFactoryConfigurationData enemyFactoryConfigurationData)
    {
        this._enemyFactoryConfigurationData = enemyFactoryConfigurationData;

        foreach (var enemyType in this._enemyFactoryConfigurationData.enemyDatas)
        {
            this._enemiesDictionary[enemyType.type] = enemyType.prefab;
        }
    }

    public GameObject Create(EnemyType enemyType)
    {
        if (!this._enemiesDictionary.TryGetValue(enemyType, out GameObject enemy))
        {
            throw new System.Exception($"EnemyType {enemyType} not found");
        }
        
        return enemy;
    }
}
