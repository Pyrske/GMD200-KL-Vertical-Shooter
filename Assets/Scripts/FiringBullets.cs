using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringBullets : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    private AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
            sound.PlayOneShot(sound.clip);
        }
    }
    private void Fire()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
