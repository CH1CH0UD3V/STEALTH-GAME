using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAttack : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] Health _health;
    [SerializeField] int damage;

    public void LaunchAttack ()
    {
        _animator.SetTrigger ("Attack");
        _health.Damage (damage);

    }
}
