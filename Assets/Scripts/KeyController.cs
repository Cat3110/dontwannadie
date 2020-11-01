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

        void Update()
        {
            transform.Rotate(0, _rotationSpeed, 0, Space.Self);
        }

        #endregion
    }
}

