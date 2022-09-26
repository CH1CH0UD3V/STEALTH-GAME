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
        _direction = new Vector3 (vector2.x, 0, vector2.y);
    }

    private void FixedUpdate ()

    {
        Debug.Log ("Tick");
        if (_direction.magnitude > 0)
        {
            if (_isRunning)
            {
                //_rb.transform.Translate (_direction * Time.fixedDeltaTime * (_speed * _accelerate));
                _rb.MovePosition (_rb.transform.position + _direction * Time.fixedDeltaTime * (_speed * _accelerate));
            }
            else
            {
                //_rb.transform.Translate (_direction * Time.fixedDeltaTime * (_speed ));
                _rb.MovePosition (_rb.transform.position + (_direction * Time.fixedDeltaTime * _speed));
            }
        }
        else
        {
            _direction = Vector3.zero;
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
