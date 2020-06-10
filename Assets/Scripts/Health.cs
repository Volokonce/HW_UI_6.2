using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private float _timeToChangeHealth;

    private float _healthValue;

    public float MaxHealth => _maxHealth;
    public float HealthValue { get => _healthValue; private set => _healthValue = value; }
        
    private void Awake()
    {
        HealthValue = _maxHealth;
    }

    public void ChangeHealth(float value)
    {        
        StartCoroutine(ChangeHealthSlow(value));
    }

    private IEnumerator ChangeHealthSlow(float value)
    {

        float tempHealthValue = HealthValue;
        float requiredHealthValue = HealthValue + value;
        float _stopwatch = 0;

        while (_stopwatch< _timeToChangeHealth)
        {            
            _stopwatch += Time.deltaTime;
            HealthValue = Mathf.Lerp(tempHealthValue, requiredHealthValue, _stopwatch / _timeToChangeHealth);
            
            _healthBar.UpdateValue();

            yield return null;
        }
    }    
}
