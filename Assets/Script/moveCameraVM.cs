using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCameraVM : MonoBehaviour
{
    [SerializeField]CinemachineVirtualCamera _vmTransition;

    private void Start ()
    {
        _vmTransition.Priority = 9;
    }
}
