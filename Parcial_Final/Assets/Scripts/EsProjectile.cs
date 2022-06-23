using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsProjectile : MonoBehaviour
{
    private Collider2D col2d;
    private Rigidbody2D rb2d;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        col2d = gameObject.GetComponent<Collider2D>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        StartCoroutine(Destroyed());
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = transform.up * speed;
    }
    IEnumerator Destroyed()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
