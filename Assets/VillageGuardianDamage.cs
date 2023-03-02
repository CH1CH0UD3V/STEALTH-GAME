using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageGuardianDamage : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        var PlayerSword = other.GetComponentInParent<SwordTag> ();
    }
}
