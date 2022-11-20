using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Unload : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        var _player = other.GetComponentInParent<PlayerTag> ();
        if (_player != null)
        {
            SceneManager.LoadScene (1);
            SceneManager.UnloadSceneAsync(0);
        }
    }
}
