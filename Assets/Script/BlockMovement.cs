using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    [SerializeField] PlayerBrain _brain;
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed;
    [SerializeField] float _accelerate;

    Vector3 _direction;
    bool _isRunning;

    public void SetDirection (Vector2 vector2)
    {
        _direction = new Vector3 (_direction.x, 0, _direction.y);
    }

    private void FixedUpdate ()

    {
        if (_direction.magnitude > 0)
        {
            _rb.MovePosition (transform.position + (_direction * Time.fixedDeltaTime * _speed));
        }
        else
        {
            _direction = Vector3.zero;
        }

        if (_isRunning)
        {
            _rb.MovePosition (_rb.transform.position + _direction * Time.fixedDeltaTime * (_speed * _accelerate));
        }
        else
        {
            _isRunning = false;
        }
    }


    public void LoadSpeed ()
    {
        _isRunning = true;
    }

    public void UnloadSpeed ()
    {
        _isRunning = false;
    }

}
