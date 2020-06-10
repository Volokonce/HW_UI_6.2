using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] private bool _rizeHealth;
    [SerializeField] private float _healthChangeValue;
    [SerializeField] private Health _gameObjectHealth;

    private void Start()
    {
        if (!_rizeHealth)
            _healthChangeValue *= -1;
    }
    public void OnButtonClick()
    {   
        
        _gameObjectHealth.ChangeHealth(_healthChangeValue);
    }
}
