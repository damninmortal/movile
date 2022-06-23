using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectile : MonoBehaviour
{
    private Collider2D col2d;
    private Rigidbody2D rb2d;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        col2d = gameObject.GetComponent<Collider2D>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        //Physics2D.GetIgnoreCollision(col2d, col2d);
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = transform.up * speed;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag != "projectile")
        {
            Destroy(gameObject);
        }

    }

}
