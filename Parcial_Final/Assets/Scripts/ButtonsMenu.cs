using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonsMenu : MonoBehaviour
{
    private string sceneContinue;
    public GameObject panelOptions;
    public GameObject panelButtons;
    public Button btnContinue;
    // Start is called before the first frame update
    void Start()
    {
        
        if (PlayerPrefs.HasKey("SceneSave"))
        {
            sceneContinue = PlayerPrefs.GetString("SceneSave");
        }
        else
        {
            btnContinue.interactable = false;
        }
        
        panelButtons.SetActive(true);
        panelOptions.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BtnStart()
    {
        PlayerPrefs.DeleteKey("SceneSave");
        PlayerPrefs.DeleteKey("PointsSave");
        LoadLevel.LevelLoad("Nivel1");
    }
    public void BtnContinue()
    {
       // LoadLevel.LevelLoad(sceneContinue);
        SceneManager.LoadScene(sceneContinue);
        GameManager.instance.points = PlayerPrefs.GetInt("PointsSave");
        GameManager.instance.lifePlayer = PlayerPrefs.GetFloat("LifeSave");
        GameManager.instance.nBombs = PlayerPrefs.GetInt("BombsSave");
    }
    public void BtnOptions()
    {
        panelOptions.SetActive(true);
        panelButtons.SetActive(false);
    }
    public void BtnQuit()
    {
        Application.Quit();
    }
    public void BtnStart2()
    {
        PlayerPrefs.DeleteKey("SceneSave");
        PlayerPrefs.DeleteKey("PointsSave");
        SceneManager.LoadScene("Nivel1");
        GameManager.instance.lifePlayer = 1.0f;
        GameManager.instance.nBombs = 3;
        GameManager.instance.points = 0;
    }

}
