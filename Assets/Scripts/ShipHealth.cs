using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : MonoBehaviour
{
    private Animator _animator;
    private AudioSource _damageNoise;
    [SerializeField] private SceneManagement _sceneManagement;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _damageNoise = GetComponent<AudioSource>();
        PlayerHealth.healthChanged += TakeDamage;
        PlayerHealth.healthChanged += Die;
    }
    private void TakeDamage(int _)
    {
        _animator.SetTrigger("TakeDamage");
        _damageNoise.PlayOneShot(_damageNoise.clip);
    }
    private void OnDisable()
    {
        PlayerHealth.healthChanged -= TakeDamage;
        PlayerHealth.healthChanged -= Die;
    }
    private void Die(int health)
    {
        if (health <= 0)
        {
            _sceneManagement.ChangeScene(2);
        }
    }
}
