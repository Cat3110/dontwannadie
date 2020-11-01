using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DontWannaDie
{
    public class EnemySpawn : MonoBehaviour
    {

        #region PrivateData

        private enum EnemyType
        {
            None    = 0,
            Spider  = 1,
            Caster  = 2
        }

        #endregion


        #region Fields

        [SerializeField] private EnemyType enemyType;
        [SerializeField] private GameObject _enemyObject;
        [SerializeField] private GameObject[] _waypointsArray;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            Instantiate(_enemyObject, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        #endregion
    }
}

