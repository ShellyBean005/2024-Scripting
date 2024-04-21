using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int typesOfEnemys;

    private float spawnRangex = 19.0f;
    private float spawnRangez = 19.0f;
    public int enemyCount;
    public int waveCount = 1;

    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (enemyCount == 0)
        {
            SpawnEnemyWave(waveCount);
            waveCount++;
        }
    }

    Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(-spawnRangex, spawnRangex);
        float zPos = Random.Range(-spawnRangez, spawnRangez);
        return new Vector3(xPos,5,zPos);
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefabs[typesOfEnemys], GenerateSpawnPosition(),transform.rotation);
        }
        ;
    }
}
