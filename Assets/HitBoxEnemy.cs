using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxEnemy : MonoBehaviour
{
    [SerializeField] BlockAttack _attack;
    private void OnTriggerEnter (Collider other)
    {
        if(Vector3.Distance(_playerCc,_distanceMin))
        {

        }
    }
}
