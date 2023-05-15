using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void NextLevel(string nextLevelName)
    {
         SceneManager.LoadScene(nextLevelName);
    }
}
