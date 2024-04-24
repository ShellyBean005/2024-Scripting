using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int typesOfEnemys;
    public GameObject player;
    private float spawnRangex = 25.0f;
    private float spawnRangez = 25.0f;
    public int enemyCount;
    public int waveCount = 1;
    private bool SpawnCheck;
    public GameObject powerUp;
    public int powerupCount;
    

    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        powerupCount = GameObject.FindGameObjectsWithTag("Powerup").Length;
        if (enemyCount == 0)
        {
            
            SpawnEnemyWave(waveCount);
            waveCount++;
        }
        

        if(enemyCount == 0 && powerupCount == 0) 
        {
            SpawnPowerup();
        }
    }

    Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(-spawnRangex, spawnRangex);
        float zPos = Random.Range(-spawnRangez, spawnRangez);


            while(xPos > player.transform.position.x - 10 && xPos < player.transform.position.x + 10)
            {
                Debug.Log("SpawnChanged");
                xPos = Random.Range(-spawnRangex, spawnRangex);
             }

            while(zPos > player.transform.position.z - 10 && zPos < player.transform.position.z + 10)
            {
            zPos = Random.Range(-spawnRangez, spawnRangez);
            Debug.Log("SpawnChanged");
            }

                return new Vector3(xPos, 5, zPos);
            
            
        
       

    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefabs[typesOfEnemys], GenerateSpawnPosition(),transform.rotation);
        }
        ;
    }

    void SpawnPowerup()
    {
        Instantiate(powerUp, GenerateSpawnPosition(), transform.rotation);
    }
}
