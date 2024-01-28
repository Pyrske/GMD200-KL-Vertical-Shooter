using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float respawnX;
    [SerializeField] private float respawnY;
    [SerializeField] private GameObject poofCloudPrefab;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        respawnX = transform.position.x;
        respawnY = transform.position.y;
    }

    // Update is called once per frame
    public void RespawnEnemy()
    {
        gameObject.SetActive(true);
        transform.position = new Vector2(respawnX,respawnY);
        _rigidbody2D.velocity = Vector2.zero;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Despawn();
            Destroy(other.gameObject);
        }
    }

    private void Despawn()
    {
        gameObject.SetActive(false);
        GameManager.Instance.UnlistEnemy(gameObject);
        Instantiate(poofCloudPrefab, transform.position, transform.rotation);
    }
}
