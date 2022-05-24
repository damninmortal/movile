using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionScript : MonoBehaviour
{
    //Volume
    [SerializeField] private Slider _volSlider;
    [SerializeField] private GameObject _panelOptions;

    //Brightness
    [SerializeField] private Slider _brightSlider;
    [SerializeField] private Image _brightImage;

    //FullScreem

    // Start is called before the first frame update
    void Start()
    {
        _panelOptions.SetActive(false);
        //Volume
        _volSlider.value = PlayerPrefs.GetFloat("VolAudio");
        AudioListener.volume = _volSlider.value;

        //Brightness
        _brightSlider.value = PlayerPrefs.GetFloat("Brightness");
        _brightImage.color = new Color(_brightImage.color.r, _brightImage.color.g, _brightImage.color.b, _brightSlider.value);
    }

    // Update is called once per frame
    void Update()
    {
  
      
    }
    //Audio Volume
    public void ChangeSliderVol()
    {
        AudioListener.volume = _volSlider.value;
    }
    //Brightness
    public void ChangeSliderBrightness()
    {
        _brightImage.color = new Color(_brightImage.color.r, _brightImage.color.g, _brightImage.color.b, _brightSlider.value);
    }
    //buttom
    public void AcceptChanges()
    {
        PlayerPrefs.SetFloat("Brightness", _brightSlider.value);
        PlayerPrefs.SetFloat("VolAudio", _volSlider.value);
        _panelOptions.SetActive(false);
    }
}
