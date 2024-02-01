using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    Animator _animator;
    [ContextMenu("Damage")]
    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }
    public void TakeDamage()
    {
        PlayerHealth.SetHealth(PlayerHealth.GetHealth()-1);
        _animator.SetBool("TakingDamage", true);
    }
}
