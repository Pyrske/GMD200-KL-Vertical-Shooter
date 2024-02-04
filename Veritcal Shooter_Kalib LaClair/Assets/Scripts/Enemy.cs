using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject poofCloudPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.ListEnemy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Despawn();
            Destroy(other.gameObject);
            GameManager.Instance.scoreValue += 10;
        }
    }

    private void Despawn()
    {
        GameManager.Instance.UnlistEnemy(gameObject);
        Instantiate(poofCloudPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
