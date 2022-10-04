using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    [SerializeField] CharacterController _cc;
    [SerializeField] Camera _cam;
    [SerializeField] Animator _animator;
    [SerializeField] bool _followCameraOrientation;
    [SerializeField] float _speed;
    [SerializeField] float _accelerate;
    [SerializeField] float _jumpForce;
    [SerializeField] float _gravity;

    Vector3 _direction;
    Vector3 _calculatedDirection;
    bool _isRunning;
    bool _isJumping;
    bool _isWalking;

    public void SetDirection (Vector2 vector2)
    {
        _direction = new Vector3 (vector2.x, 0, vector2.y);
       
    }

    private void Update ()
    {
        if (_direction.magnitude > 0)
        {
            _isWalking = true;

            Vector3 dir = Vector3.zero;
            if (_isRunning)
            {
                dir = (_direction * Time.fixedDeltaTime * _speed*_accelerate);
            }
            else
            {
                dir = (_direction * Time.fixedDeltaTime * _speed);
            }

            if (_followCameraOrientation)//direction de la cam derriere le joueur qui reste fixé derriere le joueur son cam.z = player.z
            {
                var forwardForCamera = _cam.transform.TransformDirection (dir);
                _calculatedDirection.x = forwardForCamera.x;
                _calculatedDirection.z = forwardForCamera.z;
            }
            else
            {
                _calculatedDirection.x = dir.x;
                _calculatedDirection.z = dir.z;
            }
        }
        else
        {
            _isWalking = false;
            _direction = Vector3.zero;
            _calculatedDirection.x = 0;
            _calculatedDirection.z = 0;
        }

        //Jump
        if (_cc.isGrounded)
        {
            _calculatedDirection.y = 0;

            if (_isJumping)
            {
                Debug.Log ("SAUUUUTTTTEEEE");
                _calculatedDirection += new Vector3(0, _jumpForce, 0);
            }
            _isJumping = false;
        }


        //Gravity
        _calculatedDirection.y += _gravity * Time.fixedDeltaTime;

        //Move + Look At
        _cc.Move(_calculatedDirection);
        if(_followCameraOrientation)
        {
            var t = _cam.transform.forward;
            t.y = 0;
            _cc.transform.LookAt (transform.position + t);
        }

        //animator
        _animator.SetBool ("IsWalking", _isWalking);
        _animator.SetFloat ("Horizontal", _calculatedDirection.x);
        _animator.SetFloat ("Vertical", _calculatedDirection.z);
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
