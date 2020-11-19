using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DontWannaDie
{
    public class GameLogic : MonoBehaviour
    {
        #region Fields

        [SerializeField] private GameObject _camera;
        [SerializeField] private GameObject _additionalCamera;
        [SerializeField] private GameObject _leftGate;
        [SerializeField] private GameObject _rightGate;
        [SerializeField] private UnityEvent _onGetKey;
        private bool _isGatesClosed = true;

        #endregion


        #region UnityMethods

        private void Start()
        {
            //_additionalCamera.SetActive(false);
            //_camera.SetActive(true);
        }


        private void Update()
        {
            //if (_isGatesClosed && (GameObject.FindGameObjectsWithTag("Key").Length == 0)) 
            //    OpenGates(_leftGate, _rightGate);
        }

        #endregion


        #region Methods

        public void OpenGates(GameObject leftGate, GameObject rightGate)
        {
            _isGatesClosed = false;
            _camera.SetActive(false);
            _additionalCamera.SetActive(true);
            _additionalCamera.transform.position = _camera.transform.position;
            _additionalCamera.transform.rotation = _camera.transform.rotation;
            Vector3 GatePosition = new Vector3((_leftGate.transform.position.x + _rightGate.transform.position.x) / 2,
                                                    (_leftGate.transform.position.y + _rightGate.transform.position.y) / 2,
                                                    (_leftGate.transform.position.z + _rightGate.transform.position.z) / 2);
            _additionalCamera.transform.position = GatePosition + new Vector3(0, 10, -5);
            DateTime now = DateTime.Now;
            rightGate.GetComponent<OpenGate>().isNeedToBeOpened = true;
            leftGate.GetComponent<OpenGate>().isNeedToBeOpened = true;
            _additionalCamera.SetActive(false);
            _camera.SetActive(true);
           


        }

        #endregion

    }

}
