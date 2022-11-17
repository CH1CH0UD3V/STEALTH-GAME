using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider _slider;
    //SerializeField] Image _healthBar;// image healthbar
    [SerializeField] Health _health;
    [SerializeField] UnityEvent _endGame;

    void Update()
    {
        _slider.minValue = 0;
        _slider.maxValue= _health.CurrentHealth;

        if (_slider.maxValue == _slider.minValue)
        {
            _endGame.Invoke();
        }
    }
}
