using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMountain : MonoBehaviour
{
    [SerializeField] GameObject _champsDeForce;
    [SerializeField] GameObject _triggerMountainsDragon;
    private void OnTriggerEnter (Collider other)
    {
        var player = other.GetComponentInParent<PlayerTag> ();
        if (player != null /*&& player.HasKey == true*/)
        {
            //un objet r�cup�r� = true;
            //if (player.ObjetR�cup�r� == true)
            //{
                  _triggerMountainsDragon.SetActive (false);
                  _champsDeForce.SetActive(false);
            //}
        }
    }
}