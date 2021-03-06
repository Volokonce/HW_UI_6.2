﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _objectWithHealth;

    private Slider _healthBar;
    private void Start()
    {
        _healthBar = GetComponent<Slider>();
    }

    public void UpdateValue()
    {
        _healthBar.value = _objectWithHealth.HealthValue / _objectWithHealth.MaxHealth;
    }
}
