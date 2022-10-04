using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxEnemy : MonoBehaviour
{
    [SerializeField] BlockAttack _attack;
    [SerializeField] float _distanceMin;
    [SerializeField] GameObject Player _playerCc;
    private void OnTriggerEnter (Collider other)
    {
        if(Vector3.Distance(_playerCc,_distanceMin))
        {

        }
    }
}
