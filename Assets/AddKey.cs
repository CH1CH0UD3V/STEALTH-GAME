using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddKey : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        var playerTag = other.GetComponentInParent<PlayerTag> ();
        if (playerTag != null)
        {
            playerTag.HasKey = true;
            Destroy(gameObject);
        }
    }
}
