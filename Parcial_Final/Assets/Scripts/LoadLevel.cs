using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LoadLevel
{
    public static string nextLevel;
    public static void LevelLoad(string sceneName)
    {
        nextLevel = sceneName;
        SceneManager.LoadScene("LoadScene");
    }
}
