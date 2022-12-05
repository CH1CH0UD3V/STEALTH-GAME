using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable_Enable_UI_3 : MonoBehaviour
{
    [SerializeField] Animator _animationHousePair1;
    [SerializeField] Animator _animationHousePair2;
    [SerializeField] Animator _animationHousePair3;
    [SerializeField] Animator _animationHousePair4;
    [SerializeField] GameObject _arrow;
    [SerializeField] GameObject _wallOfLimits;

    //bool _Passed;
    //bool _secondPassed;
    //bool _thirdPassed;
    //bool _fourthPassed;

    private void OnTriggerEnter (Collider other)
    {
        var player = other.GetComponentInParent<PlayerTag> ();
        if (player != null && player.HasKey == true)
        {
            //_Passed = false;
            //_secondPassed = false;
            //_thirdPassed = false;
            //_fourthPassed = false;
            _arrow.SetActive (false);
            _wallOfLimits.SetActive (false);
            _animationHousePair1.SetBool ("Passed", false/*_Passed*/);
            _animationHousePair2.SetBool ("SecondPassed", false/*_secondPassed*/);
            _animationHousePair3.SetBool ("ThirdPassed", false/*_thirdPassed*/);
            _animationHousePair4.SetBool ("FourthPassed", false/*_fourthPassed*/);
        }
    }
}
