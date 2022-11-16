using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] int _healthMax;
    [SerializeField] int _currentHealth;
    [SerializeField] Animator _animationDie;
    [SerializeField] GameObject _enemy;
    [SerializeField] GameObject _player;

    //[SerializeField] int _healing;

    bool _IsDead;

    public int HealthMax { get => _healthMax; }
    public int CurrentHealth { get => _currentHealth; set => _currentHealth = value; }

    private void Start ()
    {
        _healthMax = CurrentHealth;
    }

    void Update()
    {
        if(CurrentHealth <= 0)
        {
            _animationDie.SetBool ("IsDead", _IsDead);
            _player.SetActive (false);
            _enemy.SetActive(false);
            Mathf.Min(0, CurrentHealth);
        }
        if (CurrentHealth > _healthMax)
        {
            Mathf.Max(_healthMax, CurrentHealth);
        }
        //if(_currentHealth < _healthMax)
        //{
        //    //si je sélectionne une potion que je vais créer plustard j'augmente de point. et du coup ce sera _currentHealth += _healing(entre 10 et 30PV).
        //    Heal (_healing);
        //}
    }

    public void Damage(int damage)
    {
        CurrentHealth -= damage;
    }

    public void Heal (int healing)
    {
        CurrentHealth += healing;
    }
}
