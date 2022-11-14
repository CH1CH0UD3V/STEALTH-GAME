using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSpawnPoint : MonoBehaviour
{
    //[SerializeField] List<GameObject> spawnPoints = new List<GameObject>();
    //
    //public List<GameObject> SpawnPoints { get => spawnPoints;}
    //
    //int lenghtList = 0;

    //a la base j'ai crée un point de spawn pour que le joueur l'enregistre et respawn dès sa mort....
    private void OnTriggerEnter (Collider other)
    {
        var playerTag = other.GetComponentInParent<PlayerTag> ();
        if (playerTag != null && playerTag.SpawnPointActivated == true)
        {
            //spawnPoints.Add (other.gameObject);
            //lenghtList++;
            playerTag.SpawnPointActivated = true;
            Debug.Log ("j'ai mis en memoire le point de sauvegarde.");

            //if (lenghtList > 1)
            //{
            //    spawnPoints.RemoveAt (lenghtList - 1);
            //}
        }
        //else
        //{
        //    return;
        //}
    }
}
