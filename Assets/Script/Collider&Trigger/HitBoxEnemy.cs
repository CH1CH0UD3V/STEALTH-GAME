using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxEnemy : MonoBehaviour
{
    [SerializeField] BlockAttack _attack;
    [SerializeField] float _heightRay;
    [SerializeField] float _rayDistance;
    [SerializeField] Transform Enemy;

    Coroutine _attackRoutine;

    private void Update ()
    {
        Debug.DrawRay (Enemy.position + Vector3.up * _heightRay, Vector3.forward * _rayDistance,Color.yellow);
    }
    private void OnTriggerEnter (Collider other)
    {
        var cc = other.GetComponentInParent<CharacterController> ();
        if (cc != null && _attackRoutine == null)
        {
            _attackRoutine = StartCoroutine (waitForAttack());
            return;
        }   
    }

    IEnumerator waitForAttack()
    {
        _attack.LaunchAttack ();
        yield return new WaitForSeconds(2);
        _attackRoutine = null;
    }
}