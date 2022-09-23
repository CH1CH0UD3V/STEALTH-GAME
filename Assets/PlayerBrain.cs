using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBrain : MonoBehaviour
{
    [SerializeField] InputActionReference _move;
    //[SerializeField] InputActionReference _interraction;
    //[SerializeField] InputActionReference _jump;
    //[SerializeField] InputActionReference _sprint;
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed;

    Vector3 _direction;

    private void Start ()
    {
        _move.action.started += StartMove;        
    }

    private void FixedUpdate ()
    {
        _rb.MovePosition (_direction * _speed * Time.fixedDeltaTime );
    }

    private void StartMove (InputAction.CallbackContext obj)
    {
        _direction = obj.ReadValue<Vector2> ();
    }
}
