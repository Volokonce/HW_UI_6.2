using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HelthBar : MonoBehaviour
{
    [SerializeField] private ObjectWithHealth _objectWithHealth;

    private Slider _healthBar;
    private void Start()
    {
        _healthBar = GetComponent<Slider>();
        _healthBar.maxValue = _objectWithHealth.MaxHealth;
        _healthBar.minValue = 0;
        _healthBar.value = _objectWithHealth.ObjectHealth;
    }

    public void UpdateValue()
    {
        _healthBar.value = _objectWithHealth.ObjectHealth;
    }
}
