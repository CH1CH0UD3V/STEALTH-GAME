using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.AI;

public class AIBrain : MonoBehaviour
{
    #region CHAMP
    [SerializeField] BlockAttack attack;
    [SerializeField] Vision _vision;
    [SerializeField] NavMeshAgent _agent;
    [SerializeField] Transform[] _path;
    [SerializeField] float _minChaseDistance;
    [SerializeField] float _attackDistance;
    //[SerializeField] ScriptableObject _sO;

    int _pathIndex;
    #endregion

    #region ENUM
    enum AIState
    {
        PATROL, CHASE, ATTACK,
    }
    AIState state;
    #endregion

    private void Start ()
    {
        state = AIState.PATROL;
        _pathIndex = 0;
        _agent.SetDestination (_path[_pathIndex].position);
    }

    #region UPDATE
    private void Update ()
    {
        switch (state)
        {
            case AIState.PATROL:

                if(_agent.remainingDistance < _agent.stoppingDistance)
                {
                    _pathIndex++;

                    if (_pathIndex >= _path.Length)
                    {
                        _pathIndex = 0;
                    }
                    _agent.SetDestination (_path[_pathIndex].position);
                }

                if(_vision.Target != null)
                {
                    state = AIState.CHASE;
                }

                break;

            case AIState.CHASE:

                if(_vision.Target == null)
                {
                    state=AIState.PATROL;
                    break;
                }

                if (Vector3.Distance(_agent.transform.position,_vision.Target.transform.position) < _minChaseDistance)
                {
                    state = AIState.ATTACK;
                }

                _agent.SetDestination (_vision.Target.transform.position);

                break;
            case AIState.ATTACK:

                if (_vision.Target == null)
                {
                    state = AIState.PATROL;
                    break;
                }

                if (Vector3.Distance(_agent.transform.position, _vision.Target.transform.position) <= _attackDistance)
                {
                    attack.LaunchAttack ();
                }

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
