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

    [SerializeField] BlockMovement movement;


    

    //Vector3 Direction
    //{
    //    get => _direction;
    //    set => _direction = value.normalized;
    //}

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
        movement.LoadSpeed ();       
    }

    private void SprintEnd (InputAction.CallbackContext obj)
    {
        movement.UnloadSpeed ();
    }

    private void StartMove (InputAction.CallbackContext obj)
    {
        movement.SetDirection(obj.ReadValue<Vector2> ());
    }

    private void EndMove (InputAction.CallbackContext obj)
    {
        movement.SetDirection (Vector2.zero);
    }
}
