using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VitalSign : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private float _speedOfHealthChange;

    private float _healthValue;

    public float MaxHealth => _maxHealth;
    public float HealthValue { get => _healthValue; private set => _healthValue = value;}
        
    private void Awake()
    {
        HealthValue = _maxHealth;
    }

    public void ChangeHealth(bool rize, float value)
    {        
        StartCoroutine(ChangeHealthSlow(rize, value));
    }

    private IEnumerator ChangeHealthSlow(bool rize, float value)
    {
        float tempValue = value;
        float step;

        while (tempValue > 0)
        {
            step = value * Time.deltaTime * _speedOfHealthChange;

            if (step > tempValue)
                HealthValue -= tempValue;
            else if (rize && HealthValue < _maxHealth)
                 HealthValue += step;
            else if(!rize && HealthValue > 0)
                HealthValue -= step;
            
            tempValue -= step;            
            _healthBar.UpdateValue();

            yield return null;
        }
    }    
}
