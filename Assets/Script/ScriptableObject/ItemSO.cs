using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "ItemSO", menuName = "MenuGame/ItemSO")]
public class ItemSO : ScriptableObject
{
    [SerializeField] string _name;//Nom de l'objet
    [SerializeField] string _description;//Description de l'objet
    [SerializeField] int _lifeRestor;//Point de vie
    [SerializeField] int _manaRestor;//Point de magie
    [SerializeField] bool _isAntiPara;//Potion Antiparalysie
    [SerializeField] bool _isFullHealing;//Guérison
    [SerializeField] int _levelUp;//Prise de niveau immédiat

    public string Name { get => _name;}
    public string Description { get => _description;}
    public int LifeRestor { get => _lifeRestor;}
    public int ManaRestor { get => _manaRestor;}
    public bool IsAntiPara { get => _isAntiPara;}
    public bool IsFullHealing { get => _isFullHealing;}
    public int LevelUp { get => _levelUp;}
}
