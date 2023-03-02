using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] int _healthMax;
    [SerializeField] int _currentHealth;
    [SerializeField] Animator _animationDie;
    [SerializeField] GameObject _enemy;
    [SerializeField] GameObject _player;
    [SerializeField] bool _ifPlayerDead;//
    [SerializeField] bool _ifEnemyDead;//

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
            if (_ifPlayerDead)//
            {//
                _animationDie.SetBool ("IsDead", _IsDead);
                //_player.SetActive (false);
                SceneManager.LoadScene (0);
            }//
            if (_ifEnemyDead)//
            {//
                _enemy.SetActive(false);
            }//            
            Mathf.Min(CurrentHealth, 0);
        }
        if (CurrentHealth > _healthMax)
        {
            Mathf.Max(_healthMax, CurrentHealth);
        }
    }

    public void Damage(int damage)
    {
        CurrentHealth -= damage;
    }

    //public void Heal (int healing)
    //{
    //    CurrentHealth += healing;
    //}
}
