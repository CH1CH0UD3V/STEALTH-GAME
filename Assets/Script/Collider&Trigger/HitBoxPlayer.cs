using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxPlayer : MonoBehaviour
{
    [SerializeField] BlockAttack _attack;
    private void OnTriggerEnter (Collider other)
    {
        if (other.GetComponentInParent<EnemyTag>())
        {
            _attack.LaunchAttack();         
        }
    }
}
