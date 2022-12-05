using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlerIK : MonoBehaviour
{
    [SerializeField] Transform _objectInRightHandFirst;
    [SerializeField] Transform _objectInRightHandSecond;
    [SerializeField] bool _ikActiveDidacticiel;
    [SerializeField] bool _ikActiveNewGame;
    [SerializeField] Animator _animation;

    private void OnAnimatorIK (int layerIndex)
    {
        if (_animation)
        {
            if (_ikActiveDidacticiel)
            {
                if (_objectInRightHandFirst != null)
                {
                    _animation.SetIKPositionWeight (AvatarIKGoal.RightHand, 2);
                    _animation.SetIKRotationWeight (AvatarIKGoal.RightHand, 2);
                    _animation.SetIKPosition (AvatarIKGoal.RightHand, _objectInRightHandFirst.position);
                    _animation.SetIKRotation (AvatarIKGoal.RightHand, _objectInRightHandFirst.rotation);
                }
            }
            else if (_ikActiveNewGame)
            {

                if (_objectInRightHandSecond != null)
                {
                    _animation.SetIKPositionWeight (AvatarIKGoal.RightHand, 1);
                    _animation.SetIKRotationWeight (AvatarIKGoal.RightHand, 1);
                    _animation.SetIKPosition (AvatarIKGoal.RightHand, _objectInRightHandSecond.position);
                    _animation.SetIKRotation (AvatarIKGoal.RightHand, _objectInRightHandSecond.rotation);
                }
            }
            else
            {
                _animation.SetIKRotationWeight (AvatarIKGoal.RightHand, 0);
                _animation.SetIKRotationWeight (AvatarIKGoal.RightHand, 0);

            }
        }
    }
}

