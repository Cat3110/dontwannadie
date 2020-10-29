using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 4.0f;
    [SerializeField] private float _rotationSpeed = 50.0f;

    private float _translation;
    private float _rotation;

    private void Update()
    {
        _translation = Input.GetAxis("Vertical");
        _rotation = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.Translate(0, 0, _translation * _speed * Time.fixedDeltaTime);
        transform.Rotate(0, _rotation * _rotationSpeed * Time.fixedDeltaTime, 0);
    }


}
