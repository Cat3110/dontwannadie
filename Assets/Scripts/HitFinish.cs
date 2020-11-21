using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DontWannaDie
{
    public class HitFinish : MonoBehaviour
    {
        #region UnityMethods

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
                Debug.Log("Player Win!");
        }

        #endregion
    }

}
