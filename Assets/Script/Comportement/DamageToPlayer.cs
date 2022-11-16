using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToPlayer : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        EnemyTag enemy = (EnemyTag) other.GetComponentInParent<EnemyTag> ();
        if (enemy != null)
        {
            /*désactiver l'ActionMap du joueur*//*---->*///StopPlay ();
            /* le NavMeshAgent de l'ennemi*//*------>*///_agent.Enable(false);
            /* afficher un texte dans l'UI qui va te dire que tu as perdu*//*------>*///_text.SetActive(true);
            /*mettre une coroutine pour que ca laisse le temps au joueur de lire*//*------>*///StartCoroutine
            /* et te respawn pas trop loin du style à l'entrée de la zone.*//*------>*///je sais pas encore comment je vais faire lol!!
        }
    }
}
