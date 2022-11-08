using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainExit : MonoBehaviour
{
    [SerializeField] CharacterController _cc;
    [SerializeField] Vector3 _notAdmitt;

    private void OnTriggerExit (Collider other)
    {
        if (other.GetComponentInParent<PlayerTag> ())
        {
            if(_cc.isGrounded == false)
            {
                _cc.transform.position = Vector3.zero;
                _cc.Move (_notAdmitt);
            }
        }
    }
}
