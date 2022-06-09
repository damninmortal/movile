using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Collider2D col2D;
    // Start is called before the first frame update
    void Start()
    {
        col2D = gameObject.GetComponent<Collider2D>();
        Physics2D.GetIgnoreCollision(col2D, col2D);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag!="projectile")
        {
            Destroy(gameObject);
        }
        
    }
}
