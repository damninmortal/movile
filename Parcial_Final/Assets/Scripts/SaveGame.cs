using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveGame : MonoBehaviour
{
    private string nameScene;
    private int points;
    // Start is called before the first frame update
     void Awake()
    {
        nameScene = SceneManager.GetActiveScene().name;
      
    }
    void Start()
    {
        points = GameManager.instance.points;
        PlayerPrefs.SetString("SceneSave", nameScene);
        PlayerPrefs.SetInt("PointsSave", GameManager.instance.points);
        PlayerPrefs.SetFloat("LifeSave", GameManager.instance.lifePlayer);
        PlayerPrefs.SetFloat("BombsSave", GameManager.instance.nBombs);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
