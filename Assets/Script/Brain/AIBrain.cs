using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBrain : MonoBehaviour
{
    #region CHAMP
    [SerializeField] BlockMovement movement;
    [SerializeField] BlockAttack attack;
    [SerializeField] ScriptableObject _sO;
    #endregion

    #region ENUM
    enum AIState
    {
        PATROL, CHASE, ATTACK,
    }
    AIState state;
    #endregion

    #region UPDATE
    private void Update ()
    {
        switch (state)
        {
            case AIState.PATROL:
                break;
            case AIState.CHASE:
                break;
            case AIState.ATTACK:
                break;
            default:
                break;
        }
    }
    #endregion

    #region METHODE
    void Patrol ()
    {
    }
    void Chase ()
    {
    }
    void Attack ()
    {
    }
    #endregion
}
