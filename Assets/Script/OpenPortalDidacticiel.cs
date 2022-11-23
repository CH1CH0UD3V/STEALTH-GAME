using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPortalDidacticiel : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _uiSautedanslevide;

    bool _IsHere;
    private void OnTriggerEnter (Collider other)
    {
        var player = other.GetComponentInParent<PlayerTag> ();
        if (player != null && player.HasKey == true)
        {
            _IsHere = true;
            _animator.SetBool ("IsHere", _IsHere);
            _uiSautedanslevide.SetActive(true);
        }

    }
}

