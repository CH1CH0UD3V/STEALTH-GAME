using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxEnemy : MonoBehaviour
{
    [SerializeField] BlockAttack _attack;
    [SerializeField] float _distanceMin;
    //[SerializeField] float _heightRay;
    [SerializeField] float _rayDistance;
    [SerializeField] Transform Enemy;

    private void Reset ()
    {
        _distanceMin = 2f;
    }

    private void Update ()
    {
        Debug.DrawRay (Enemy.position + Vector3.up /** _heightRay*/, Vector3.forward * _rayDistance,Color.yellow);
    }
    private void OnTriggerEnter (Collider other)
    {
        if(other is CharacterController)
        {
            _attack.LaunchAttack ();
            return;
        }

        var cc = other.GetComponentInParent<CharacterController> ();
        if (cc != null)
        {
            _attack.LaunchAttack ();
            return;
        }

        
    }
}
