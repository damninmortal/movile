using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Components
    private Rigidbody2D rb2d;

    //Input
    [SerializeField]private Joystick joystick;

    //Variables
    [SerializeField]private float velocity=3;
    [SerializeField] private float jump = 6;
    [SerializeField] private bool moveVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 dir = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;
        if (moveVelocity==true)
        {
            rb2d.velocity = new Vector2(dir.x * velocity*11 * Time.deltaTime, rb2d.velocity.y);
            
        }
        else
        {
            rb2d.AddForce(dir * velocity * Time.deltaTime, ForceMode2D.Impulse);
        }
    
        if (Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(Vector2.up*jump,ForceMode2D.Impulse);
        }
       

    }
}
