using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTag : MonoBehaviour
{
    [SerializeField] int maxKey;
    [SerializeField] int _currentKey;
    [SerializeField] TextMeshProUGUI _keyCount;
    public bool HasKey { get; internal set; }  // essai de li� le playertag a un autre script qui a le trigger et qui detecte les objets tel les cl�s.

    // quand je vais recup�rer la cl�, playertag va stocker la valeur et haskey passe � true pour ouvrir une porte.
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