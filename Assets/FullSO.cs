using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[CreateAssetMenu (fileName = "FullSO", menuName = "MenuGame/FullSO")]
public class FullSO : ScriptableObject//le bordel fait l'identification du personnage et peut lancer des raycasthits dans tout les sens.
{
    [Header("Propriété de base du S0")]
    [SerializeField] GameObject _character;
    [SerializeField] string _name;
    [SerializeField] int _age;
    [SerializeField] float _pV;
    [SerializeField] float _pA;
    [SerializeField] float _pD;
    [SerializeField] float _pM;

    [Header ("Champs Bonus")]
    [SerializeField] float _minDistance;

    public GameObject Character { get => _character;}// glisser le gameobject du personnage qui va subir le script.
    public string Name { get => _name;}// mettre un nom pour le personnage.
    public int Age { get => _age;}//lui donner un age.
    public float PV { get => _pV;}//lui donner ses points de vie.
    public float PA { get => _pA;}//lui donner ses points d'attaque.
    public float PD { get => _pD;}//lui donner ses points de défense.
    public float PM { get => _pM;}//lui donner ses points de magie.



    private void Update ()
    {
        Normal_Forward ();
        Normal_Left ();
        Normal_Right();
        Normal_Back();
        Grounded ();
    }

    public void Normal_Forward () 
    {
        RaycastHit hit;
        Ray _ray = new Ray (Character.transform.position, Vector3.forward);
        if(Physics.Raycast (_ray, out hit))
        {
            Debug.Log ($"{hit.transform.name} est à {hit.distance} mètres  droit devant moi");
            Vector3 _normalFWD = hit.normal;
            Vector3 _pointImpactFWD = hit.point;
            float _distanceFWD = hit.distance;
            Rigidbody _rbFWD = hit.rigidbody;
        }
    }
    public void Normal_Left ()
    {
        RaycastHit hit;
        Ray _ray = new Ray (Character.transform.position, Vector3.left);
        if (Physics.Raycast (_ray, out hit))
        {
            Debug.Log ($"{hit.transform.name} est à {hit.distance} mètres àma gauche");
            Vector3 _normalL = hit.normal;
            Vector3 _pointImpactL = hit.point;
            float _distanceL = hit.distance;
            //Rigidbody _rbL = hit.rigidbody;
        }
    }
    public void Normal_Right ()
    {
        RaycastHit hit;
        Ray _ray = new Ray (Character.transform.position, Vector3.right);
        if (Physics.Raycast (_ray, out hit))
        {
            Debug.Log ($"{hit.transform.name} est à {hit.distance} mètres à ma droite");
            Vector3 _normalR = hit.normal;
            Vector3 _pointImpactR = hit.point;
            float _distanceR = hit.distance;
            //Rigidbody _rbR = hit.rigidbody;
        }
    }
    public void Normal_Back ()
    {
        RaycastHit hit;
        Ray _ray = new Ray (Character.transform.position, Vector3.back);
        if (Physics.Raycast (_ray, out hit))
        {
            Debug.Log ($"{hit.transform.name} est à {hit.distance} mètres derrière moi");
            Vector3 _normalBCK = hit.normal;
            Vector3 _pointImpactBCK = hit.point;
            float _distanceBCK = hit.distance;
            //Rigidbody _rbBCK = hit.rigidbody;
        }
    }
    public void Grounded ()
    {
        RaycastHit hit;
        Ray _ray = new Ray (Character.transform.position, Vector3.down);
        if (Physics.Raycast (_ray, out hit))
        {
            Debug.Log ($"{hit.transform.name} est à {hit.distance} mètres en dessous de moi");
            Vector3 _normalDWN = hit.normal;
            Vector3 _pointImpactDWN = hit.point;
            float _distanceDWN = hit.distance;
        }
    }

}
