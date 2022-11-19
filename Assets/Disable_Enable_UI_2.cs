using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable_Enable_UI_2 : MonoBehaviour
{
    [Header ("Animation")]
    [SerializeField] Animator _animationHousePair3;
    [SerializeField] Animator _animationHousePair4;
    [SerializeField] GameObject _secondUi;

    bool _thirdPassed;
    bool _fourthPassed;


    private void OnTriggerEnter (Collider other)
    {
        var player = other.GetComponentInParent<PlayerTag> ();
        if (player != null)
        {
            _secondUi.SetActive (false);
            _thirdPassed = true;
            _fourthPassed = true;
            _animationHousePair3.SetBool ("ThirdPassed", _thirdPassed);
            _animationHousePair4.SetBool ("FourthPassed", _fourthPassed);
        }
    }
}
