using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] int _healthMax;
    //[SerializeField] Animator _animationDie;
    //[SerializeField] UnityEvent _die;
    //[SerializeField] UnityEvent _touch;

    [SerializeField] int _currentHealth, _healing;

    public int HealthMax { get => _healthMax; }

    private void Start ()
    {
        _healthMax = _currentHealth;
    }

    void Update()
    {
        if(_currentHealth <= 0)
        {
           //_die.Invoke();
            Mathf.Min(0, _currentHealth);
        }
        if (_currentHealth > _healthMax)
        {
            Mathf.Max(_healthMax, _currentHealth);
        }
        if(_currentHealth < _healthMax)
        {
            //si je sélectionne une potion que je vais créer plustard j'augmente de point. et du coup ce sera _currentHealth += _healing(entre 10 et 30PV).
            Heal (_healing);
        }
    }

    public void Damage(int damage)
    {
        _currentHealth -= damage;
    }

    public void Heal (int healing)
    {
        _currentHealth += healing;
    }
}
