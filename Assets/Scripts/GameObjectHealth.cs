using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameObjectHealth : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    private float _objectHealth;

    public float MaxHealth => _maxHealth;
    public float ObjectHealth { get => _objectHealth; private set => _objectHealth = value;}

    private void Start()
    {
        ObjectHealth = _maxHealth;
    }

    public void ChangeHealth(bool rize, float value)
    {
        if (rize)
            StartCoroutine(ChangeHealthSlow(rize, value));
        else
            StartCoroutine(ChangeHealthSlow(rize, value));
    }

    private IEnumerator ChangeHealthSlow(bool rize, float value)
    {
        float cureentHealth = ObjectHealth;
        var waitingTime = new WaitForSeconds(1);

        for (int i = 0; i < 5; i++)
        {
            if (rize)
                ObjectHealth += value/5;
            else
                ObjectHealth -= value/5;
            yield return waitingTime;
        }
    }
}
