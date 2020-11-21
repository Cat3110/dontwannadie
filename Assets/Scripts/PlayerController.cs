using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DontWannaDie
{
    public class PlayerController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private float _moveSpeed = 4.0f;
        [SerializeField] private float _rotationSpeed = 50.0f;
        private float _translation;
        private float _rotation;
        private Animator _animator;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            _translation = Input.GetAxis("Vertical");
            _rotation = Input.GetAxis("Horizontal");

            if(Input.GetAxis("Vertical") == 0)
            {
                _animator.SetBool("isMove", false);
            }
            else
            {
                _animator.SetBool("isMove", true);
            }

            print(Input.GetAxis("Vertical"));
        }

        private void FixedUpdate()
        {
            
            transform.Translate(0, 0, _translation * _moveSpeed * Time.fixedDeltaTime);
            transform.Rotate(0, _rotation * _rotationSpeed * Time.fixedDeltaTime, 0);
        }

        #endregion
    }
}

