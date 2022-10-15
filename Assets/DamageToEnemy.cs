using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamageToEnemy : MonoBehaviour
{
    [SerializeField] GameObject[] _enemy;
    private void OnTriggerEnter (Collider other)
    {
        foreach (var e in _enemy)
        {
            Destroy(e.gameObject);
        }
    }
}
