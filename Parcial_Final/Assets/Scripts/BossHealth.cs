using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public float healthValue = 1f;
    public float shieldValue = 1f;
    public float damageHealth;
    public float damageShield;
    public Image imageHealth;
    public Image imageShield;

    public Panel panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        imageHealth.fillAmount = healthValue;
        imageShield.fillAmount = shieldValue;
        if (shieldValue<=0)
        {
            shieldValue = 0f;
        }
        if (healthValue<=0)
        {
            panel.Next();
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="projectile")
        {
            if (shieldValue>0)
            {
                shieldValue -= damageShield;
            }
            else
            {
               
                healthValue -= damageHealth;
            }
        }
        if (collision.gameObject.tag == "Esprojectile")
        {
            if (shieldValue > 0)
            {
                shieldValue -= damageShield*5;
            }
            else
            {
                healthValue -= damageHealth*10;
            }
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="Player")
        {
            GameManager.instance.lifePlayer = 0;
        }
    }

}
