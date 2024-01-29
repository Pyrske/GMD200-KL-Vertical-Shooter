using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] public string SceneName;
 
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneName);
    }

}
