using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPortal : MonoBehaviour
{
    [SerializeField] Animator _animator;

    bool _IsHere;
    private void OnTriggerEnter (Collider other)
    {
        var player = other.GetComponentInParent<PlayerTag> ();
        if ( player != null && player.HasKey == true)
        {
            _IsHere = true;
            _animator.SetBool ("IsHere", _IsHere);
        }
        player.HasKey= true;
        
    }

    private void OnTriggerExit (Collider other)
    {
        StartCoroutine (await(other));
    }

    IEnumerator await (Collider other)
    {
        var player = other.GetComponentInParent<PlayerTag> ();
        if (player != null && player.HasKey == false)
        {
            _IsHere = false;
            yield return new WaitForSeconds (5);
            _animator.SetBool ("IsHere", _IsHere);
        }
    }
}
