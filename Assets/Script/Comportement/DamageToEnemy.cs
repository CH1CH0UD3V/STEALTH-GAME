using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamageToEnemy : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        EnemyTag enemy = other.GetComponentInParent<EnemyTag>();
        Debug.Log ("oh touche moi");


        if (enemy)
        {
            Destroy (enemy.gameObject);
        }
    }
}