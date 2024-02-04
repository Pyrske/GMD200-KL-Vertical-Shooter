using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private List<GameObject> activeEnemyList;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private TMP_Text _scoreText;
    private static int _scoreValue;
    public static int staticScore
    {
        get { return _scoreValue; }
    }
    public int scoreValue
    {
        get { return _scoreValue; }
        set {
            if (value < 0) value = 0;
            _scoreValue = value; 
            _scoreText.text = _scoreValue.ToString().PadLeft(4, '0');
        }
    }

    private void Awake()
    {
        Instance = this;
        Debug.Log(Instance);
        activeEnemyList = new List<GameObject>();
    }

    private void Start()
    {
        _scoreValue = 0;
        ResetAllEnemies(5);
        PlayerHealth.SetHealth(6);
    }

    public void ListEnemy(GameObject enemy)
    {
        activeEnemyList.Add(enemy);
    }

    public void UnlistEnemy(GameObject enemy)
    {
        activeEnemyList.Remove(enemy);
        if (activeEnemyList.Count == 0)
        {
            StartCoroutine(Co_ResetAllEnemiesDelayed(1f));
        }
    }

    private IEnumerator Co_ResetAllEnemiesDelayed(float delay)
    {
        yield return new WaitForSeconds(delay);
        ResetAllEnemies(5);
    }

    private void ResetAllEnemies(int enemyCount)
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Vector3 spawnPosition = Vector3.zero;
            while(spawnPosition.sqrMagnitude < 4)
            {
                spawnPosition = new Vector3(Random.Range(-6f, 6f), Random.Range(-3.5f, 3));
            }
            Instantiate(_enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
