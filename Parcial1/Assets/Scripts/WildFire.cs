using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildFire : MonoBehaviour
{
    bool touch=false;
    [SerializeField]private Transform objective;
    [SerializeField] private float speed;

    Collider2D col2d;
    // Start is called before the first frame update
    void Start()
    {
        col2d = GetComponent<Collider2D>();
        objective = GameObject.FindGameObjectWithTag("target").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        float distance;
        if (touch==true)
        {
            transform.position = Vector3.MoveTowards(transform.position, objective.position,step);
            distance = transform.position.y - objective.position.y;
            if (distance>=-0.1)
            {
                Destroy(gameObject);
            }
            //Debug.Log(transform.position);
        } 
    }
    //public void OnCollisionEnter2D(Collision2D col)
    //{
    //    if (col.gameObject.tag=="player")
    //    {
    //        touch = true;
    //        col2d.enabled = !col2d.enabled;
    //    }
    //}
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player")
        {
            touch = true;
            col2d.enabled = !col2d.enabled;
        }
    }
}
