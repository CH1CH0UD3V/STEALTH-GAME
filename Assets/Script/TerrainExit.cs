using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrainExit : MonoBehaviour
{ 
    private void OnTriggerExit (Collider other)
    {
        var playerTag = other.GetComponentInParent<PlayerTag> ();
        //var player = GameObject.Find (playerTag.name);
        if (playerTag)
        {
            SceneManager.LoadScene (0);
            
        }
    }
}

















            //var DistanceOfSpawn = Vector3.Distance (other.transform.position, _spwaney.transform.position );
            //if (DistanceOfSpawn < )
            //{
            //}