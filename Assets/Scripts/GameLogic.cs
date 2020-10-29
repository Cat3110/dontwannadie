using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    private GameObject[] spawnPoints;

    private void Awake()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");

        foreach(GameObject spawnPoint in spawnPoints)
        {
            GameObject enemy = Instantiate(spawnPoint.GetComponent<EnemySpawn>().enemy, spawnPoint.transform.position, spawnPoint.transform.rotation);

            switch (spawnPoint.GetComponent<EnemySpawn>().enemyType)
            {
                case EnemySpawn.EnemyType.spider:
                    break;
                case EnemySpawn.EnemyType.caster:
                    enemy.transform.Rotate(0, 90, 0);
                    break;
                default:
                    break;
            }

            spawnPoint.SetActive(false);
        }
    } 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
