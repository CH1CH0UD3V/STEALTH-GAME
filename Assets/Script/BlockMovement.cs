using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    [SerializeField] PlayerBrain _brain;
    [SerializeField] CharacterController _cc;
    [SerializeField] float _speed;
    [SerializeField] float _accelerate;
    [SerializeField] Camera _cam;

    Vector3 _direction;
    Vector3 _calculatedDirection;
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
            var dir = (_direction * Time.fixedDeltaTime * _speed);
            if (_isRunning)
            {
                //_rb.transform.Translate (_direction * Time.fixedDeltaTime * (_speed * _accelerate));
                //_rb.MovePosition (_rb.transform.position + dir*_accelerate);
                _cc.Move (dir * _accelerate);
            }
            else
            {
                //_rb.transform.Translate (_direction * Time.fixedDeltaTime * (_speed ));
                //_rb.MovePosition (_rb.transform.position + dir);
                _cc.Move (dir);
            }
        }
        else
        {
            _direction = Vector3.zero;
        }
        //Gravity
        if (_cc.isGrounded)
        {
            _calculatedDirection.y = 0;
        }
        else
        {
            _calculatedDirection.y = Physics.gravity / 3 * Time.fixedDeltaTime;
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
