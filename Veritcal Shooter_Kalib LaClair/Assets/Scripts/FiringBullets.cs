using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringBullets : MonoBehaviour
{
    [SerializeField] private Transform spawnLocation;

    [SerializeField] private GameObject bulletPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    private void Fire()
    {
        Instantiate(bulletPrefab, spawnLocation.position, spawnLocation.rotation);
    }
}
