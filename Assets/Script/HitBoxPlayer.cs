using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxPlayer : MonoBehaviour
{
    [SerializeField] 
    private void OnTriggerEnter (Collider other)
    {
        if (other.TryGetComponent<EnemyTag>(out var Enemy))
        {

        }
    }
}
