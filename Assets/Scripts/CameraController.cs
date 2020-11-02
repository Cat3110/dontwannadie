using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


namespace DontWannaDie
{
    public class CameraController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Vector3 _cameraOffset;
        private GameObject _target;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            _target = GameObject.FindGameObjectWithTag("Player");
        }

        private void FixedUpdate()
        {
            CamFollow(_target);
        }

        #endregion


        #region Methods

        private void CamFollow(GameObject target)
        {
            if ((_target.transform.rotation.eulerAngles.y - transform.rotation.eulerAngles.y) != 0)
            {
                transform.RotateAround(_target.transform.position, Vector3.up, _target.transform.rotation.eulerAngles.y - transform.rotation.eulerAngles.y);
                _cameraOffset = transform.position - _target.transform.position;
            }

            transform.position = _target.transform.position + _cameraOffset;
        }

        #endregion
    }
}

