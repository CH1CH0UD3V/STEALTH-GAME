using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    [SerializeField] CharacterController _cc;
    [SerializeField] Camera _cam;
    [SerializeField] Animator _animator;
    [Space(25)]
    [SerializeField] bool _followCameraOrientation;
    [SerializeField] float _speed;
    [SerializeField] float _accelerate;
    [SerializeField] float _jumpForce;
    [SerializeField] float _gravity;
    [Space(25)]
    [SerializeField] GameObject _leftArrowWhite;
    [SerializeField] GameObject _leftArrowRed;
    [SerializeField] GameObject _rightArrowWhite;
    [SerializeField] GameObject _rightArrowRed;
    [SerializeField] GameObject _upArrowWhite;
    [SerializeField] GameObject _upArrowRed;
    [SerializeField] GameObject _downArrowWhite;
    [SerializeField] GameObject _downArrowRed;
    [Space(25)]

    Vector3 _direction;
    Vector3 _calculatedDirection;
    bool _isRunning;
    bool _isJumping;
    bool _isWalking;

    public void SetDirection (Vector2 vector2)
    {
        _direction = new Vector3 (vector2.x, 0, vector2.y);

        # region Left ou Left and Up ou Left and Down
        if (vector2.x == -1 )
        {
            _leftArrowWhite.SetActive(false);
            _leftArrowRed.SetActive(true);
            if(vector2.y == 1)
            {
                _upArrowRed.SetActive (true);
                _upArrowWhite.SetActive (false);
            }
            else if (vector2.y == -1)
            {
                _downArrowRed.SetActive (true);
                _downArrowWhite.SetActive (false);
            }
            else
            {
                _upArrowRed.SetActive (false);
                _upArrowWhite.SetActive (true);
                _downArrowRed.SetActive (false);
                _downArrowWhite.SetActive (true);
            }
        }
        else
        {
            _leftArrowWhite.SetActive(true);
            _leftArrowRed.SetActive(false);
        }
        #endregion

        #region UP
        if (vector2.y == 1 )
        {
            _upArrowWhite.SetActive(false);
            _upArrowRed.SetActive(true);
        }
        else
        {
            _upArrowWhite.SetActive (true);
            _upArrowRed.SetActive (false);
        }
        #endregion

        #region Down
        if (vector2.y == -1)
        {
            _downArrowWhite.SetActive(false);
            _downArrowRed.SetActive(true);
        }
        else
        {
            _downArrowWhite.SetActive(true);
            _downArrowRed.SetActive(false);
        }
        #endregion

        #region Right
        if (vector2.x == 1)
        {
            _rightArrowWhite.SetActive (false);
            _rightArrowRed.SetActive (true);
            if (vector2.y == 1)
            {
                _upArrowRed.SetActive (true);
                _upArrowWhite.SetActive (false);
            }
            else if (vector2.y == -1)
            {
                _downArrowRed.SetActive (true);
                _downArrowWhite.SetActive (false);
            }
            else
            {
                _upArrowRed.SetActive (false);
                _upArrowWhite.SetActive (true);
                _downArrowRed.SetActive (false);
                _downArrowWhite.SetActive (true);
            }
        }
        else
        {
            _rightArrowWhite.SetActive (true);
            _rightArrowRed.SetActive (false);
        }
        #endregion


    }

    private void Update ()
    {
        if (_direction.magnitude > 0)
        {
            _isWalking = true;

            Vector3 dir = Vector3.zero;
            if (_isRunning)
            {
                dir = (_direction * Time.deltaTime * _speed*_accelerate);
            }
            else
            {
                dir = (_direction * Time.deltaTime * _speed);
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

        //Move + Look At // Pour dire au personnage de se tourner dans la direction de l'input
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
