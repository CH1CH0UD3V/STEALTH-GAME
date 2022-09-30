using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    [SerializeField] PlayerBrain _brain;
    [SerializeField] CharacterController _cc;
    [SerializeField] Camera _cam;
    [SerializeField] bool _followCameraOrientation;
    [SerializeField] float _speed;
    [SerializeField] float _accelerate;
    [SerializeField] float _jumpForce;
    [SerializeField] float _gravity;

    Vector3 _direction;
    Vector3 _calculatedDirection;
    bool _isRunning;
    bool _isJumping;

    public void SetDirection (Vector2 vector2)
    {
        _direction = new Vector3 (vector2.x, 0, vector2.y);
    }

    private void FixedUpdate ()
    {
        
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
            if (_followCameraOrientation)//direction de la cam derriere le joueur qui reste fixé derriere le joueur son cam.z = player.z
            {
                var forwardForCamera = _cam.transform.TransformDirection (dir);
                _calculatedDirection.x = forwardForCamera.x;
                _calculatedDirection.y = forwardForCamera.y;
            }
            else
            {

            }
        }
        else
        {
            _direction = Vector3.zero;
            _calculatedDirection.x = 0;
            _calculatedDirection.z = 0;
        }

        //Jump
        if (_cc.isGrounded)
        {
            _calculatedDirection.y = 0;
        }

        if (_isJumping)
        {
            _isJumping = false;
            Debug.Log ("SAUUUUTTTTEEEE");
            _calculatedDirection += new Vector3(0, _jumpForce, 0);
        }

        //Gravity
        _calculatedDirection.y += _gravity * Time.fixedDeltaTime;
        _cc.Move(_calculatedDirection);
    }


    public void LoadSpeed ()
    {
        _isRunning = true;
    }

    public void UnloadSpeed ()
    {
        _isRunning = false;
    }

    public void LaunchJump ()
    {
        _isJumping = true;
    }

}
