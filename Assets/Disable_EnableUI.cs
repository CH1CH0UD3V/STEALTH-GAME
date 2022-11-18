using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable_EnableUI : MonoBehaviour
{
    [SerializeField] GameObject _firstUi;
    [SerializeField] GameObject _secondUi;


    private void OnTriggerEnter (Collider other)
    {
        var player = other.GetComponentInParent<PlayerTag> ();
        if (player != null)
        {
            StartCoroutine (await());
        }
    }

    IEnumerator await ()
    {
        _firstUi.SetActive (false);
        yield return new WaitForSeconds(5);
        _secondUi.SetActive (true);
    }
}
