using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DontWannaDie
{
    public class OpenGate : MonoBehaviour
    {
        #region Fields

        [SerializeField] private float _rotateAngle;
        public bool isNeedToBeOpened = false;
        private Quaternion _targetRotation;


        #endregion


        #region UnityMethods

        private void Start()
        {
            _targetRotation = Quaternion.Euler(transform.eulerAngles.x, _rotateAngle, transform.eulerAngles.z);
        }

        private void Update()
        {
            if (isNeedToBeOpened)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, _targetRotation, Time.deltaTime);
            }
        }

        #endregion
    }
}

