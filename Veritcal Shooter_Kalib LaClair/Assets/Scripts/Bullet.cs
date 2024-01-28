using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    [SerializeField] private float bulletLife = 1f;

    private float life = 0f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        life += Time.deltaTime;
        if (life >= bulletLife)
        {
            Destroy(gameObject);
            PlayerHealth.Damage();
        }
    }
}
