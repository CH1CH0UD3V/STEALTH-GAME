using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToPlayer : MonoBehaviour
{
    [SerializeField] GameObject[] _enemy;
    private void OnTriggerEnter (Collider other)
    {
        foreach (var e in _enemy)
        {
            if (other == e)
            {
                Destroy (e.gameObject);
            }
        }
    }
}
