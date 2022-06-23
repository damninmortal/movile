using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int points;
    public float lifePlayer;
    public int nBombs;
    

    void Awake()
    {
        if (PlayerPrefs.HasKey("PointsSave"))
        {
            points = PlayerPrefs.GetInt("PointsSave");
            lifePlayer = PlayerPrefs.GetFloat("LifeSave");
            nBombs = PlayerPrefs.GetInt("BombsSave");
           
        }
        else
        {
            lifePlayer = 1.0f;
            nBombs = 3;
            points = 0;
        }
        Time.timeScale = 1;
        MakeSingleton();
        

    }

    private void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void BombsUsed()
    {
        nBombs--;
    }
    public void Score()
    {
        points+=10;
    }
    public void AddLife()
    {
        if (lifePlayer<1f)
        {
            lifePlayer += 0.25f;
        }
    }
}
