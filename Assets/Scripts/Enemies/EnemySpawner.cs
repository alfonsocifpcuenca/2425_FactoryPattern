using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyFactoryConfigurationData _enemyFactoryConfigurationData;
    [SerializeField] private EnemyType _enemyType;

    private void Start()
    {
        var enemyFactory = new EnemyFactory(this._enemyFactoryConfigurationData);
        var enemy = enemyFactory.Create(this._enemyType);
        Instantiate(enemy);
    }
}
