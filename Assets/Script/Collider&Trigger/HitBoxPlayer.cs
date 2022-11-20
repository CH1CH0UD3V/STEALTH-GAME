using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxPlayer : MonoBehaviour
{
    [SerializeField] BlockAttack _attack;
    private void OnTriggerEnter (Collider other)
    {
        var enemy = other.GetComponentInParent<EnemyTag> ();
        if (enemy != null )
        {
            _attack.LaunchAttack();            
            return;
        }
        else
        {
            return;
        }
    }
}
