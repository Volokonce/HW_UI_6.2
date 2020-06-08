using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] private bool _rizeHealth;
    [SerializeField] private float _healthChangeValue;
    [SerializeField] private GameObjectHealth _gameObjectHealth;
    [SerializeField] private Slider _healthBar;

    public void OnButtonClick()
    {
        if (_rizeHealth && _gameObjectHealth.ObjectHealth < _gameObjectHealth.MaxHealth)
            _gameObjectHealth.ChangeHealth(true, _healthChangeValue);
        else if (!_rizeHealth && _gameObjectHealth.ObjectHealth > 0)
            _gameObjectHealth.ChangeHealth(false, _healthChangeValue);
        _healthBar.value = _gameObjectHealth.ObjectHealth;

    }
}
