using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject[] enemyArray;
    public List<GameObject> activeEnemyList;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy");
        
        activeEnemyList = new List<GameObject>(enemyArray);
    }

    public void UnlistEnemy(GameObject enemy)
    {
        activeEnemyList.Remove(enemy);
        if (activeEnemyList.Count == 0)
        {
            StartCoroutine(Co_ResetAllEnemiesDelayed(2f));
        }
    }

    private IEnumerator Co_ResetAllEnemiesDelayed(float delay)
    {
        yield return new WaitForSeconds(delay);
        ResetAllEnemies();
    }

    private void ResetAllEnemies()
    {
        foreach (var enemy in enemyArray)
        {
            enemy.GetComponent<Enemy>().RespawnEnemy();
            activeEnemyList.Add(enemy);
        }
    }
}
