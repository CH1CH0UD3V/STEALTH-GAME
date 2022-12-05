using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LauchGame : MonoBehaviour
{
    //normalement le menu principal étant une scene,il devra prendre place en 0, mais pas tout de suite donc je reviendrai dans ce script plus tard.
    public void StartFirstLevel ()
    {
        SceneManager.LoadScene (0);//execute dans la logique la scene du didacticiel mais dans le doute verifer dans build settings.
    }

    public void StartSecondLevel ()
    {
        SceneManager.LoadScene (1);//execute dans la logique la scene principale mais dans le doute verifer dans build settings.
    }
}
