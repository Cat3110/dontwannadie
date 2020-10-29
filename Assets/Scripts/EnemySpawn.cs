using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public enum EnemyType
    {
        spider,
        caster
    }

    public EnemyType enemyType;

    public GameObject enemy;

    public GameObject[] waypoints;
}
