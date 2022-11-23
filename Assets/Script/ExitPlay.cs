using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class ExitPlay : MonoBehaviour
{
    public void QuitGame ()
    {
        Application.Quit ();
    }
}
