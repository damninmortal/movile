using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Slider volumen;
    public GameObject panelButtons;
    // Start is called before the first frame update
    void Start()
    {
        volumen.value = PlayerPrefs.GetFloat("VolAudio");
        AudioListener.volume = volumen.value;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeSliderVol()
    {
        AudioListener.volume = volumen.value;
    }
    public void AcceptChanges()
    {
        PlayerPrefs.SetFloat("VolAudio", volumen.value);
        gameObject.SetActive(false);
        panelButtons.SetActive(true);
        
    }
}
