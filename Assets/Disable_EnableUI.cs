using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable_EnableUI : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] GameObject _firstUi;
    [SerializeField] GameObject _secondUi;
    [Header("Animation")]
    [SerializeField] Animator _animationHousePair1;
    [SerializeField] Animator _animationHousePair2;

    bool _firstPassed;
    bool _secondPassed;


    private void OnTriggerEnter (Collider other)
    {
        var player = other.GetComponentInParent<PlayerTag> ();
        if (player != null)
        {
            StartCoroutine (await ()); 
        }
    }

    IEnumerator await ()
    {
        yield return new WaitForSeconds(0.8f);
        _firstUi.SetActive (false);
        _secondUi.SetActive (true);
        _firstPassed = true;
        _secondPassed = true;
        _animationHousePair1.SetBool ("Passed", _firstPassed);
        _animationHousePair2.SetBool ("SecondPassed", _secondPassed);
    }
}
