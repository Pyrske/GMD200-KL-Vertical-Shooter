using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoad : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        if (index == 1)
        {
            Destroy(gameObject);
            return;
        }
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Music");
        for (int i = 1; i < objects.Length; i++)
        {
            Destroy(objects[i]);
        }
        DontDestroyOnLoad(objects[0]);
    }
}
