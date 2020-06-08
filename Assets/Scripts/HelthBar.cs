using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HelthBar : MonoBehaviour
{

    [SerializeField] private GameObjectHealth _gameObjectHealth;
    [SerializeField] private TMP_Text _text;

    private Slider _healthBar;
    private void Start()
    {
        _healthBar = GetComponent<Slider>();
        _healthBar.maxValue = _gameObjectHealth.MaxHealth;
        _healthBar.minValue = 0;
        _text.text = _gameObjectHealth.ObjectHealth.ToString(); 
    }

    public void PrintHealth()
    {
        _text.text = _gameObjectHealth.ObjectHealth.ToString();
    }


}
