using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTag : MonoBehaviour
{
    //[SerializeField] int maxKey;
    //[SerializeField] int _currentKey;
    //[SerializeField] TextMeshProUGUI _keyCount;
    public bool HasKey { get; internal set; }  // lie le playertag au script AddKey qui a le trigger et qui detecte le personnage et passe � true.
    // quand je vais recup�rer la cl�, playertag va stocker la valeur et haskey passe � true dans la cl� pour ouvrir la porte.
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