using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Panel panel;

    private void Awake()
    {
      
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameManager.instance.lifePlayer<=0)
        {
            panel.GameOver();
            gameObject.SetActive(false);
        }
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if ( col.gameObject.tag=="Enemy"||col.gameObject.tag=="Enemy1"||col.gameObject.tag=="Enemy2")
        {
            GameManager.instance.lifePlayer -= 0.5f;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="projectile")
        {
            GameManager.instance.lifePlayer -= 0.25f;
            Debug.Log("te daño");
        }
    }
}
