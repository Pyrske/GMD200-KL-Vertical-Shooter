using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Image[] shipImages;
    [SerializeField] private int numSegments = 2;
    private void OnEnable()
    {
        PlayerHealth.healthChanged += OnHealthChanged;
        OnHealthChanged(PlayerHealth.GetHealth());
    }

    private void OnDisable()
    {
        PlayerHealth.healthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(int health)
    {
        Debug.Log("Health: " + health);
        for (int i = 0; i < shipImages.Length; i++)
        {
            shipImages[i].fillAmount = (health - i * numSegments) / (float) numSegments;
        }
    }

}
