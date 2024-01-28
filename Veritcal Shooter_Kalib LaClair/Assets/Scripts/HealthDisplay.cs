using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerHealth.healthChanged += OnHealthChanged;
    }
    private void OnDisable()
    {
        PlayerHealth.healthChanged -= OnHealthChanged;
    }
    private void OnHealthChanged(int obj)
    {
        Debug.Log("Health: " + obj);
    }

}
