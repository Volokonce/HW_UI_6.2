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
    [SerializeField] private ObjectWithHealth _gameObjectHealth;

    public void OnButtonClick()
    {        
        _gameObjectHealth.ChangeHealth(_rizeHealth, _healthChangeValue);
    }
}
