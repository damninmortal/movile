using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnProjectile;
    public float speed;
    public float rateFire;
    private float rateIntern;
    private bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit2D = Physics2D.Raycast(spawnProjectile.position, transform.up);
        if (hit2D.collider.tag=="Player")
        {
            attack();
        }
     

        if (canShoot == false)
        {
            rateIntern -= 1 * Time.deltaTime;
            if (rateIntern <= 0)
            {
                canShoot = true;
            }
        }
    }
    public void attack()
    {
        if (canShoot == true)
        {
            GameObject instProjectile =
                Instantiate(projectile, spawnProjectile.position, projectile.transform.rotation);
            Rigidbody2D rbProjectile = instProjectile.GetComponent<Rigidbody2D>();
            rbProjectile.velocity = transform.up * speed;
            rateIntern = rateFire;
            canShoot = false;
        }
    }
}
