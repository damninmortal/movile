using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pause : MonoBehaviour
{
    public GameObject panel;
    public bool pause = false;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buton()
    {
        Debug.Log("entry");
        if (pause==false)
        {
            pause = true;
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
        if (pause==true)
        {
            pause = false;
            panel.SetActive(false);
            Time.timeScale = 1f;
        }

    }
}
