using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAttack : MonoBehaviour
{
    [SerializeField] Animator _animatorAttack;
    ///[SerializeField] Animator _animatorHit;
    [SerializeField] Health _health;
    [SerializeField] int damage;

    public void LaunchAttack ()
    {
        _animatorAttack.SetTrigger ("Attack");
        //_animatorHit.SetTrigger ("Hit");
        _health.Damage (damage);
        Debug.Log ($" Fait bellek, ta vie descend il te reste,{_health.CurrentHealth}PV, soit tu fuis,soit tu lui démontes sa grand-mère.");

    }
}
