using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBrain : MonoBehaviour
{
    #region Champ
    [Header ("Input")]
    [SerializeField] InputActionReference _move;
    //[SerializeField] InputActionReference _interraction;
    [SerializeField] InputActionReference _jump;
    [SerializeField] InputActionReference _sprint;
    [SerializeField] InputActionReference _attack;

    [Header ("")]
    [SerializeField] BlockMovement movement;
    [SerializeField] BlockAttack attack;
    //[SerializeField] ScriptableObject _sO; //l'utiliser plus tard
    #endregion


    #region void Start
    private void Start ()
    {
        _move.action.started += StartMove;
        _move.action.performed += StartMove;
        _move.action.canceled += EndMove;

        _sprint.action.started += SprintStart;
        _sprint.action.canceled += SprintEnd;

        _jump.action.started += JumpStart;

        _attack.action.started += StartAttack;
    }
    #endregion

    #region OnDestroy
    private void OnDestroy ()
    {
        _move.action.started -= StartMove;
        _move.action.performed -= StartMove;
        _move.action.canceled -= EndMove;

        _sprint.action.started -= SprintStart;
        _sprint.action.canceled -= SprintEnd;

        _jump.action.started -= JumpStart;

        _attack.action.started -= StartAttack;
    }
    #endregion


    #region Move
    private void StartMove (InputAction.CallbackContext obj)
    {
        movement.SetDirection(obj.ReadValue<Vector2> ());
    }

    private void EndMove (InputAction.CallbackContext obj)
    {
        movement.SetDirection (Vector2.zero);
    }
    #endregion

    #region Sprint
    private void SprintStart (InputAction.CallbackContext obj)
    {
        movement.LoadSpeed ();       
    }

    private void SprintEnd (InputAction.CallbackContext obj)
    {
        movement.UnloadSpeed ();
    }
    #endregion


    #region Jump
    private void JumpStart (InputAction.CallbackContext obj)
    {
        movement.LaunchJump();
    }
    #endregion

    #region Attack
    private void StartAttack (InputAction.CallbackContext obj)
    {
        attack.LaunchAttack ();
    }
    #endregion
}