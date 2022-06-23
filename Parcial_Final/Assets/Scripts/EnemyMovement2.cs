using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    public float speedX,speedY;
    public Transform target;
    private Rigidbody2D rb2d;
    private bool launched = false;


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
        float distance = Vector2.Distance(transform.position, target.position);
        
        if (distance >= 6.9f)
        {
            Movement(dir);
            
        }
        else if (distance<6.9 && launched == false )
        {
            StartCoroutine(Preparation(dir));
            
        }
        else if (distance < 6.9 && launched == true)
        {
            Kamikaze();
            
        }

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
    IEnumerator Preparation(Vector2 dir)
    {
        dir.y = (-speedY * 0) * Time.deltaTime;
        rb2d.velocity = new Vector2(0f, dir.y);
        transform.up = target.position - transform.position;
        yield return new WaitForSeconds(1.25f);
        launched = true;
    }
    void Kamikaze()
    {
        rb2d.velocity = transform.up * 4;
    }
}
