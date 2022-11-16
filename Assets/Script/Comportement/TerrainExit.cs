using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrainExit : MonoBehaviour
{
    [SerializeField] GameObject SpawnPoint;
    private void OnTriggerExit (Collider other)
    {
        var playerTag = other.GetComponentInParent<PlayerTag> ();
        //var player = GameObject.Find (playerTag.name);
        if (playerTag != null && playerTag.SpawnPointActivated ==true)
        {
            SceneManager.LoadScene (0);
            //Destroy (transform.parent.gameObject);
            //Instantiate (other, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
            
        }
    }
}

















            //var DistanceOfSpawn = Vector3.Distance (other.transform.position, _spwaney.transform.position );
            //if (DistanceOfSpawn < )
            //{
            //}