using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBrain : MonoBehaviour
{
    [SerializeField] InputActionReference _move;
    //[SerializeField] InputActionReference _interraction;
    //[SerializeField] InputActionReference _jump;
    [SerializeField] InputActionReference _sprint;
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed;
    [SerializeField] float _accelerate;

    Vector3 _direction;
    bool _isRunning;
    Vector3 Direction
    {
        get => _direction;
        set => _direction = value.normalized;
    }

    private void Start ()
    {
        _move.action.started += StartMove;
        _move.action.performed += StartMove;
        _move.action.canceled += EndMove;
        _sprint.action.started += SprintStart;
        _sprint.action.canceled += SprintEnd;
    }


    private void SprintStart (InputAction.CallbackContext obj)
    {
        _isRunning = true;
    }

    private void SprintEnd (InputAction.CallbackContext obj)
    {
        _isRunning = false;
    }

    private void FixedUpdate ()
    {
        if (_isRunning)
        {
            _rb.MovePosition (_rb.transform.position +_direction * Time.fixedDeltaTime * (_speed * _accelerate));
        }
        else
        {
            _rb.MovePosition (_rb.transform.position + _direction * _speed * Time.fixedDeltaTime );
        }
    }

    private void StartMove (InputAction.CallbackContext obj)
    {
        _direction = obj.ReadValue<Vector2> ();
        _direction = new Vector3(_direction.x, 0, _direction.y);
    }

    private void EndMove (InputAction.CallbackContext obj)
    {
        _direction = Vector3.zero;
    }
}
