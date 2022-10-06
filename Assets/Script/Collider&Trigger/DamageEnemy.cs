using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        if (other.TryGetComponent<SwordTag>(out var swordTag))
        {
            Destroy(gameObject);
        }
    }
}
