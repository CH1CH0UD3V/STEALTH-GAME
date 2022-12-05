using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMountain : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        var player = other.GetComponentInParent<PlayerTag> ();
        if (player != null && player.HasKey == true)
        {
            //un objet récupéré = true;
            //if (player.ObjetRécupéré == true)
            //{
                  //trigger.SetActive (false);
                  //ChampsDeForce.SetActive(false);
            //}
        }
    }
}
