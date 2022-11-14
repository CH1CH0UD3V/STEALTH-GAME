using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddKey : MonoBehaviour
{
    [SerializeField] GameObject _keyImage;
    [SerializeField] AudioSource _keyAddAudio;
    private void OnTriggerEnter (Collider other)
    {
        var playerTag = other.GetComponentInParent<PlayerTag> ();
        if (playerTag != null)
        {
            playerTag.HasKey = true;
            Destroy (transform.parent.gameObject);
            _keyImage.SetActive (true);
        }
    }
}
