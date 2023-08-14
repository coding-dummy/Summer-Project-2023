using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    public Enemy currentEnemy;

    public Transform canvas;

    public static enemyManager instance;

    void Awake()
    {
        instance = this;
    }

    public void spawnEnemy()
    {
        GameObject enemyToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject obj = Instantiate(enemyToSpawn, canvas);

        currentEnemy = obj.GetComponent<Enemy>();
    }

    public void replaceEnemy(GameObject Enemy)
    {
        Destroy(Enemy);
        spawnEnemy();
    }

}
