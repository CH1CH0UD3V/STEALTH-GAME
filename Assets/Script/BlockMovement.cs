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
    [SerializeField] bool _followCameraOrientation;

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
        }
        //Gravity
        if (_cc.isGrounded)
        {
            _calculatedDirection.y = 0;
        }
        else
        {
            _calculatedDirection.y += -3 * Time.fixedDeltaTime;
        }
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
        throw new NotImplementedException ();
    }
}
