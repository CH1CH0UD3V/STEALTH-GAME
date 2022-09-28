using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterSO", menuName = "MenuGame/CharacterSO")]
public class CharacterSO : ScriptableObject
{
    [SerializeField] string _name;
    [SerializeField] string _clan;
    [SerializeField] int _age;
    [SerializeField] int _maxHealth;
    [SerializeField] int _maxDefense;
    [SerializeField] int _maxMana;

    public string Name { get => _name;}
    public string Clan { get => _clan; }
    public int Âge { get => _age;}
    public int MaxHealth { get => _maxHealth;}
    public int MaxDefense { get => _maxDefense;}
    public int MaxMana { get => _maxMana;}
}
