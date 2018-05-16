using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    private int waveNumber;
    private float waveTime;
    private float enemyWaitTime = 5.0f;

	// Use this for initialization
	void Start () {
        waveNumber = 0;
        StartCoroutine(WaitForEnemy());
    }

    IEnumerator WaitForEnemy()
    {
        while (Player.instance.isAlive()) // make it player still alive
        {
            yield return new WaitForSeconds(enemyWaitTime);
            SpawnEnemyAtRandomPoint();
        }
    }

    void SpawnEnemyAtRandomPoint()
    {
        Debug.Log("An enemy is spawned");
    }
}
