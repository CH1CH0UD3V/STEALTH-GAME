using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class moveCameraVM : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera _vmTransitionDepart;
    [SerializeField] GameObject _vmTransitionDepartOb;
    [SerializeField] GameObject _vmTransitionIntermediaire;
    [SerializeField] GameObject _vmPlayer;
    [SerializeField] PlayerBrain _player;
    [SerializeField] float _timeForWait;

    private void Start ()
    {
        StartCoroutine(TransitionCamera());
    }

    IEnumerator TransitionCamera ()
    {
        _vmTransitionDepart.Priority = 10;
        _vmTransitionIntermediaire.SetActive(true);
        yield return new WaitForSeconds(_timeForWait);
        _vmTransitionDepartOb.SetActive(false);
        _vmTransitionIntermediaire.SetActive (false);
        yield return new WaitForSeconds(_timeForWait);
        _vmPlayer.SetActive(true);

    }
}
