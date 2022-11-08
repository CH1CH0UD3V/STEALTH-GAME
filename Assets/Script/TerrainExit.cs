using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrainExit : MonoBehaviour
{
    //[SerializeField] CharacterController _cc;
    //[SerializeField] Vector3 _notAdmitt;
    //[SerializeField] SpawnPoint _spwaney ;

    private void OnTriggerExit (Collider other)
    {
        if (other.GetComponentInParent<PlayerTag> ())
        {
            SceneManager.LoadScene (0);
            //if(_cc.isGrounded == false)
            //{
            //    _cc.transform.position = Vector3.zero;
            //    _cc.Move (_notAdmitt);
            //}
        }
    }
}
