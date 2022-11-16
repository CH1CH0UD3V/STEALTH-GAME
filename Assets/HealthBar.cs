using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider _slider;
    //SerializeField] Image _healthBar;// image healthbar
    [SerializeField] Health _health;

    void Update()
    {
        _slider.value = _health.CurrentHealth;
        _slider.maxValue= _health.CurrentHealth;
    }
}
