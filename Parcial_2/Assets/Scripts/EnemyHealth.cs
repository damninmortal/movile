using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float health = 1.0f;
    public float shield = 1.0f;
    public bool eShield;
    public Image healthBar;
    public Image shieldBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shieldBar.fillAmount = shield;
        healthBar.fillAmount = health;
        if (shield<=0)
        {
            eShield = false;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "projectile")
        {
            if (eShield==true)
            {
                shield -= 0.5f;
            }
            else
            {
                health -= 0.5f;
            }
           
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Eliminador" || collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
