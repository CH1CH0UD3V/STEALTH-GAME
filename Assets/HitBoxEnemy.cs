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
    private void OnTriggerEnter (Collider other)
    {
        float _distance = Vector3.Distance (other.transform.position, transform.position);
        Debug.DrawLine (Enemy.transform.position + Vector3.up /** _heightRay*/, Vector3.forward * _rayDistance,Color.yellow);
        if (_distance < _distanceMin)
        {
            _attack.LaunchAttack ();
        }
    }
}
