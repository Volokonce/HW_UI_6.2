using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjectWithHealth : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private HelthBar _healthBar;

    private float _objectHealth;

    public float MaxHealth => _maxHealth;
    public float ObjectHealth { get => _objectHealth; private set => _objectHealth = value;}
        
    private void Awake()
    {
        ObjectHealth = _maxHealth;
    }

    public void ChangeHealth(bool rize, float value)
    {        
        StartCoroutine(ChangeHealthSlow(rize, value));
    }

    public IEnumerator ChangeHealthSlow(bool rize, float value)
    {
        var waitingTime = new WaitForSeconds(0.05f);

        for (int i = 0; i < value; i++)
        {
            if (rize && ObjectHealth<_maxHealth)
                 ObjectHealth++;
            else if(!rize && ObjectHealth>0)
                ObjectHealth--;

            _healthBar.UpdateValue();

            yield return waitingTime;
        }
    }
    
}
