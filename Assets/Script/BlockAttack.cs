using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAttack : MonoBehaviour
{
    [SerializeField] PlayerBrain _pBrain;
    [SerializeField] AIBrain _eBrain;
    [SerializeField] Animator _animator;

    public void LaunchAttack ()
    {
        _animator.SetTrigger ("Attack");
    }
}
