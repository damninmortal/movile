using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField]private Joystick joystick;
    private float mov;
    [SerializeField]private float velocity=3;
    //[SerializeField] private float velocityRun = 3;
    [SerializeField] private float jump = 6;
    [SerializeField] private bool moveVelocity;

    [SerializeField] private Text contText;
    //private int cont = 0;
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
       
     
        //mov = Input.GetAxis("Horizontal");
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    rb2d.velocity = new Vector2(mov * velocity*velocityRun, rb2d.velocity.y);
        //}
        //else
        //{
        //    rb2d.velocity = new Vector2(mov * velocity, rb2d.velocity.y);
        //}
        if (Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(Vector2.up*jump,ForceMode2D.Impulse);
        }
        contText.text = "= " + GameManager.instance.coins;

    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="wildfire")
        {
            GameManager.instance.coins++;
        }
    }
}
