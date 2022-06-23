using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public GameObject btnContinueLevel;
    public GameObject btnNextLevel;
    public GameObject btnQuitLevel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
        btnContinueLevel.SetActive(false);
        btnNextLevel.SetActive(false);
        btnQuitLevel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void GameOver()
    {
        Time.timeScale = 0f;
        gameObject.SetActive(true);
        btnContinueLevel.SetActive(false);
        btnNextLevel.SetActive(false);
        btnQuitLevel.SetActive(true);
    }
    public void Next()
    {
        Time.timeScale = 0f;
        gameObject.SetActive(true);
        btnContinueLevel.SetActive(false);
        btnNextLevel.SetActive(true);
        btnQuitLevel.SetActive(true);
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        gameObject.SetActive(true);
        btnContinueLevel.SetActive(true);
        btnNextLevel.SetActive(false);
        btnQuitLevel.SetActive(true);
    }
    public void BtnContinuar()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
        btnContinueLevel.SetActive(false);
        btnNextLevel.SetActive(false);
        btnQuitLevel.SetActive(false);
    }
    public void BtnScene(string nameScene)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(nameScene);
        
    }


}
