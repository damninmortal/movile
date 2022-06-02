using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelBright : MonoBehaviour
{
    [SerializeField] private Image _brightnessPanel;
    // Start is called before the first frame update
    void Start()
    {
        _brightnessPanel = gameObject.GetComponent<Image>();
        _brightnessPanel.color = new Color(_brightnessPanel.color.r, _brightnessPanel.color.g, _brightnessPanel.color.b, PlayerPrefs.GetFloat("Brightness"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
