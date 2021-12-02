using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject spherePrefab;

    public List<Transform> spawnPoints = new List<Transform>();
    public List<GameObject> enemiesAlive = new List<GameObject>();
    // Start is called before the first frame update
    private void OnEnable()
    {
        EventManager.OnSpawnEvent += AddEnemy;
        EventManager.OnDeathEvent += RemoveEnemy;
    }

    private void OnDisable()
    {
        EventManager.OnSpawnEvent -= AddEnemy;
        EventManager.OnDeathEvent -= RemoveEnemy;
    }

    private void RemoveEnemy(GameObject enemy)
    {
        enemiesAlive.Remove(enemy);
    }

    private void AddEnemy(GameObject enemy)
    {
        enemiesAlive.Add(enemy);
    }
    void Start()
    {
        for (int i = 0;  i < spawnPoints.Count; i++)
        {
            Instantiate(enemyPrefab, spawnPoints[i].position, Quaternion.identity);
            Instantiate(spherePrefab, spawnPoints[i].position + new Vector3(0, 5f, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
