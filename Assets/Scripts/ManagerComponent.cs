using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerComponent : MonoBehaviour
{

    // Player Transform position for future enemy detection 
    public Transform PlayerTransform;

    [SerializeField]
    private GameObject _orcPrefab;

    [SerializeField]
    private GameObject _trollPrefab;

    [SerializeField]
    private GameObject _goblinPrefab;


    // Serializable count of how many enemies to spawn. 
    [Header("Spawn Counts")]

    [SerializeField]
    private int _orcCount = 2;

    [SerializeField]
    private int _trollCount = 2;

    [SerializeField]
    private int _goblinCount = 2;

    private List<GameObject> _enemies = new List<GameObject>();

    

    
    void Start()
    {
        EnemySpawner(Enums.EnemyType.Orc, _orcCount);
        EnemySpawner(Enums.EnemyType.Troll, _trollCount);
        EnemySpawner(Enums.EnemyType.Goblin, _goblinCount);
    }

   
    void Update()
    {
        DistanceChecker();
    }

    void DistanceChecker()
    {
        foreach (GameObject enemy in _enemies)
        {
            float distanceToPlayer = Vector3.Distance(PlayerTransform.position, enemy.transform.position);
            EnemyComponent enemyComponent = enemy.GetComponent<EnemyComponent>();

            if (distanceToPlayer <= enemyComponent._attackRange)
            {
                //PrepareToShoot(enemy, enemyComponent);
            }

          
        }
    }

    void PrepareToShoot(GameObject enemy, EnemyComponent enemyComponent)
    {
        //enemyComponent.ShootProjectile();
    }

    void EnemySpawner(Enums.EnemyType enemyType, int count)
    {
        GameObject prefabsToSpawn = null;

        switch (enemyType)
        {
            case Enums.EnemyType.Orc:
                prefabsToSpawn = _orcPrefab;
                break;
            case Enums.EnemyType.Troll:
                prefabsToSpawn = _trollPrefab;
                break;
            case Enums.EnemyType.Goblin:
                prefabsToSpawn = _goblinPrefab;
                break;
        }

        if (prefabsToSpawn != null)
        {
            for (int i = 0; i < count; i++)
            {
                // Spawnponits can be added here
                GameObject enemy = Instantiate(prefabsToSpawn, transform.position, Quaternion.identity);
                _enemies.Add(enemy);
            }
        }
    }
}
