using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField] private Joystick joystick;

    [SerializeField] private float velocity = 3;
    [SerializeField] private float jump = 6;
    [SerializeField] private bool moveVelocity;

    [SerializeField] private Animator anim;
    [SerializeField] private GameObject projectile;

    [SerializeField] private Text contText;
    public string scene;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool move = false;
        Vector2 dir = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;
        anim.SetFloat("speed", dir.x);
        
        if (moveVelocity == true)
        {
            rb2d.velocity = new Vector2(dir.x * velocity * 11 * Time.deltaTime, rb2d.velocity.y);
          

        }
        else
        {
          
            rb2d.AddForce(dir * velocity * Time.deltaTime, ForceMode2D.Impulse);
            
        }

        if (Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
       // contText.text = "= " + GameManager.instance.coins;
      

    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "wildfire")
        {
            GameManager.instance.coins++;
        }
        if (col.gameObject.tag=="finish")
        {
            SceneManager.LoadScene(scene);
        }
    }
    //public void OnCollisionEnter2D(Collision2D col)
    //{
    //    if (col.gameObject.tag == "wildfire")
    //    {
    //        GameManager.instance.coins++;
    //    }
    //}
    public void Jump()
    {
        rb2d.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
    }
    public void attack()
    {
        Instantiate(projectile,transform.position,transform.rotation);
    }
}
