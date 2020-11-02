using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DontWannaDie
{
    public class KeyController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private float _rotationSpeed;

        #endregion


        #region UnityMethods

        private void FixedUpdate()
        {
            transform.Rotate(0, _rotationSpeed, 0, Space.Self);
        }

        private void OnCollisionEnter(Collision collision)
        {
            Destroy(this.gameObject);
        }

        #endregion
    }
}

