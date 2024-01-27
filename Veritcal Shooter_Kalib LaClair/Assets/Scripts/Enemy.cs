using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float respawnX;
    [SerializeField] private float respawnY = 1;

    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        respawnX = transform.position.x;
    }

    // Update is called once per frame
    public void RespawnEnemy()
    {
        gameObject.SetActive(true);
        transform.position = new Vector2(respawnX,respawnY);
        _rigidbody2D.velocity = Vector2.zero;
    }
}
