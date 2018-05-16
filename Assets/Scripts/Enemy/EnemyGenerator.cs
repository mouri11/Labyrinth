using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    private int waveNumber;
    private float waveTime;
    private float enemyWaitTime = 5.0f;

    [SerializeField]
    Transform[] spawnPositions;

    [SerializeField]
    GameObject enemyPrefab;

    // Use this for initialization
    void Start () {
        waveNumber = 0;
        StartCoroutine(WaitForEnemy());
    }

    IEnumerator WaitForEnemy()
    {
        Debug.Log("Spawning enemies");
        while (Player.instance.isAlive()) // make it player still alive
        {
            yield return new WaitForSeconds(enemyWaitTime);
            SpawnEnemyAtRandomPoint();
        }
        Debug.Log("Player is Dead");
    }

    void SpawnEnemyAtRandomPoint()
    {
        Transform spawnPoint = spawnPositions[Random.Range(0, spawnPositions.Length - 1)];
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Debug.Log("An enemy is spawned");
    }
}
