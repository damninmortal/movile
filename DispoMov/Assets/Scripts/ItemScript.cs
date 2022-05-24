using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemScript : MonoBehaviour
{
    [SerializeField] private string _itemName;
    [SerializeField] private string _itemCost;
    [SerializeField] private string _itemDescription;
    [SerializeField] private GameObject _textDescription;
    [SerializeField] private Image _itemImage;
    [SerializeField] private Sprite _itemSprite;
    // Start is called before the first frame update
    void Start()
    {
        _textDescription = GameObject.FindGameObjectWithTag("Description");
       // _itemImage = gameObject.GetComponentsInChildren<Image>();
        _itemImage.sprite = _itemSprite;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SeeItem()
    {
        _textDescription.GetComponent<Text>().text = _itemDescription;
    }
}
