using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health = 1.0f;
    public Image healthBar;
    public Panel panel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health;
        if (health<=0)
        {
            panel.GameOver();
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if ( col.gameObject.tag=="Enemy"||col.gameObject.tag=="Enemy1"||col.gameObject.tag=="Enemy2")
        {
            health -= 0.5f;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="projectile")
        {
            health -= 0.25f;
        }
    }
}
