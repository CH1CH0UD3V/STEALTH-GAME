using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSpawnPoint : MonoBehaviour
{
    //a la base j'ai crée un point de spawn pour que le joueur l'enregistre et respawn dès sa mort....
    private void OnTriggerEnter (Collider other)
    {
        //other.GetComponentInParent<SpawnerTag> ();
    }
}
