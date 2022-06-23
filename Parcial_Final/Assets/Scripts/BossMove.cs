using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public int fase;
    public float speed;
    public float speedF3;
    public float speedF4;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision(6, 6);
        speedF3 = speed * 1.5f;
        speedF4 = speed * 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Vector2.zero;
        switch (fase)
        {   
            case 1:
                dir.x = speed * Time.deltaTime;
                break;
            case 3:
                dir.x = speedF3 * Time.deltaTime;
                break;
            case 4:
                dir.x = speedF4 * Time.deltaTime;
                break;
            default:
                dir.x = speed * Time.deltaTime;
                break;

        }
        rb2d.velocity = new Vector2(dir.x, 0.0f);
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("MainCamera"))
        {
            ChangeDirection();
        }
    }
    private void ChangeDirection()
    {
        speed *= -1;
        speedF3 *= -1;
        speedF4 *= -1;
    }

}
