using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPortal : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] bool _IsHere;

    //bool _IsHere;
    private void OnTriggerEnter (Collider other)
    {
        var player = other.GetComponentInParent<PlayerTag> ();
        if ( player != null  /*&& player.HasKey == true*/)
        {
            _IsHere = true;
            _animator.SetBool ("IsHere", _IsHere);
        }
        
    }

    private void OnTriggerExit (Collider other)
    {
        var player = other.GetComponentInParent<PlayerTag> ();
        if (player != null)
        {
            _IsHere = false;
            _animator.SetBool ("IsHere", _IsHere);
        }
    }
}
