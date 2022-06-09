using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement3 : MonoBehaviour
{
    public float speedX,speedY;
    public Transform target;
    private Rigidbody2D rb2d;



    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        Physics2D.IgnoreLayerCollision(6, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 dir = Vector2.zero;    
        Movement(dir);
    }
    void Movement(Vector2 dir)
    {
        transform.position =
            Vector3.MoveTowards
            (transform.position,
            new Vector3(target.position.x, transform.position.y, transform.position.z),
            speedX);

        dir.y = -speedY * Time.deltaTime;
        rb2d.velocity = new Vector2(0f, dir.y);
    }
    
}
