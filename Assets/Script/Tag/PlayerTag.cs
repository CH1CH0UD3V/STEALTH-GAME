using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTag : MonoBehaviour
{
    //[SerializeField] int maxKey;
    //[SerializeField] int _currentKey;
    //[SerializeField] TextMeshProUGUI _keyCount;
    public bool HasKey { get; internal set; }  // lie le playertag au script AddKey qui a le trigger et qui detecte le personnage et passe à true.
    // quand je vais recupérer la clé, playertag va stocker la valeur et haskey passe à true dans la clé pour ouvrir la porte.
    public bool SpawnPointActivated { get; internal set; }

}

    





        















//private void OnTriggerEnter (Collider other)
            //{
            //    _key = 0;
            //    if (other.GetComponentInParent<KeyTag> ())
            //    {
            //        Key (other);
            //    }
            //}
            //
            //IEnumerable Key (Collider other)
            //{
            //    HasKey = true;
            //    Destroy (other.gameObject);
            //    _key ++;
            //}