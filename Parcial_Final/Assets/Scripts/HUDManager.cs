using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Image healtPlayerImage;
    public Text bombsPlayerTxt;
    public Text scorePlayerTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healtPlayerImage.fillAmount = GameManager.instance.lifePlayer;
        bombsPlayerTxt.text = "X " + GameManager.instance.nBombs.ToString();
        scorePlayerTxt.text = "S: " + GameManager.instance.points.ToString();
    }
}
