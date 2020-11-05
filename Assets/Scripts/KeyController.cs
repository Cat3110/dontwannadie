﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DontWannaDie
{
    public class KeyController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private float _rotationSpeed;
        [SerializeField] private UnityEvent _onGetKey;

        #endregion


        #region UnityMethods
        private void Start()
        {
            _onGetKey = new UnityEvent();
        }

        private void FixedUpdate()
        {
            transform.Rotate(0, _rotationSpeed, 0, Space.Self);
        }

        private void OnCollisionEnter(Collision collision)
        {
            _onGetKey.Invoke();
            Destroy(this.gameObject);
        }

        #endregion
    }
}

