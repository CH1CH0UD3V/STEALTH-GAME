using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKLeftFoot : MonoBehaviour
{
    [SerializeField] float _distanceRaycast; //Longeur du raycast.


    private void Update ()
    {
        //CONDITION SI LE RAYCAST TOUCHE OU PAS
        bool Ray = Physics.Raycast (transform.position, Vector3.down * _distanceRaycast, LayerMask.GetMask ("Environement"));
        if (Ray)
        {
            Debug.Log ("j'ai touché un truc je crois bien mais me demande pas quoi poto, je suis pas assez payé pour chercher");
            Debug.DrawRay (transform.position, Vector3.down * _distanceRaycast, Color.green);  //ca envoi un rayon vert a chaque update.
            transform.Translate (0, -_distanceRaycast, 0);
        }
        else
        {
            Debug.DrawRay (transform.position, Vector3.down * _distanceRaycast, Color.red);  //ca envoi un rayon rouge à chaque update.
            return;
        }
    }
}