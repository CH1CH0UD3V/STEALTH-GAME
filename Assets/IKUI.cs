using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKUI : MonoBehaviour
{
    [Header("ObjectOfVision")]
    [SerializeField] Animator _animator;
    [Space (10)]
    [SerializeField] Transform _play;
    [Space (10)]
    [SerializeField] Transform _exit;
    [Space (10)]
    [SerializeField] Transform _didacticiel;
    [Space (10)]
    [SerializeField] Transform _newGame;
    [Space(25)]
    [Header("VisionSelection")]    
    [SerializeField] bool IKActivePlay;
    [Space (10)]
    [SerializeField] bool IKActiveExit;
    [Space (10)]
    [SerializeField] bool IKActiveDidacticiel;
    [Space (10)]
    [SerializeField] bool IKActiveNewGame;

    //bool IKActive;
    private void OnAnimatorIK (int layerIndex)
    {
        if (_animator)
        {
            if (IKActivePlay)
            {
                //Mathf.Clamp01 ();
                //Vector3.Lerp (transform.position, _play.position, 0.5f);
                _animator.SetLookAtPosition(_play.position);
            }
            if (IKActiveExit)
            {
                //Vector3.Lerp (transform.position, _exit.position, 0.5f);
                _animator.SetLookAtPosition(_exit.position);
            }
            if (IKActiveDidacticiel)
            {
                //Vector3.Lerp (transform.position, _didacticiel.position, 0.5f);
                _animator.SetLookAtPosition(_didacticiel.position);
            }
            if (IKActiveNewGame)
            {
                //Vector3.Lerp (transform.position, _newGame.position, 0.5f);
                _animator.SetLookAtPosition(_newGame.position);
            }
        }
    }
}
