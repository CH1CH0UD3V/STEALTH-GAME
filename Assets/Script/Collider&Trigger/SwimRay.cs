using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimRay : MonoBehaviour
{
   [SerializeField] float _distance;
   [SerializeField] Animator _animator;
   [SerializeField] CharacterController _cc;

    private void OnTriggerEnter (Collider other)
    {
        Debug.DrawRay (transform.position,Vector3.forward * _distance,Color.white);

        if(Physics.Raycast(transform.position,other.transform.position, out _))
        {
            _animator.SetTrigger ("Swimming");
            
        }
    }
}
