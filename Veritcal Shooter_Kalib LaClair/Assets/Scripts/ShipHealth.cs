using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : MonoBehaviour
{
    Animator _animator;
    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
        PlayerHealth.healthChanged += PlayDamageAnimation;
    }
    private void PlayDamageAnimation(int _)
    {
        _animator.SetTrigger("TakeDamage");
    }
    private void OnDisable()
    {
        PlayerHealth.healthChanged -= PlayDamageAnimation;
    }
}
