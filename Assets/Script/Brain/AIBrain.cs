using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBrain : MonoBehaviour
{
    [SerializeField] BlockMovement movement;
    [SerializeField] BlockAttack attack;
    [SerializeField] ScriptableObject _sO;
    enum AIState
    {
        PATROL, CHASE, ATTACK,
    }
    AIState state;

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

    void Patrol ()
    {
    }
    void Chase ()
    {
    }
    void Attack ()
    {
    }
    
}
