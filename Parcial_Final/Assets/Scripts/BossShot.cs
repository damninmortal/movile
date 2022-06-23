using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShot : MonoBehaviour
{
    public Transform spawnProjectile;
    private Transform target;
    private float rateIntern;
    private bool canShoot = true;
    public int maxProjectile=4;
    private bool canShootBurst=false;
    private GameObject[] projectileNum;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //quantity per burst
        projectileNum = GameObject.FindGameObjectsWithTag("Burst");
        int num = projectileNum.Length;
       
        if (num==maxProjectile)
        {
            canShootBurst = false;
        }
        if (num==0)
        {
            canShootBurst = true;
        }
        //rate shot
        if (canShoot == false)
        {
            rateIntern -= 1 * Time.deltaTime;
            if (rateIntern <= 0)
            {
                canShoot = true;
            }
        }        
    }
    public void Attack(GameObject projectile, float rateFire)
    {
        if (canShoot == true )
        {
            Instantiate(projectile, spawnProjectile.position, projectile.transform.rotation);
            rateIntern = rateFire;
            canShoot = false;
        }
    }
    public void AttackFase3(GameObject projectile, float rateFire)
    {
        spawnProjectile.transform.up = target.position - spawnProjectile.position;
        if (canShoot == true && canShootBurst==true)
        {
            Instantiate(projectile, spawnProjectile.transform.position, spawnProjectile.transform.rotation);
            rateIntern = rateFire;
            canShoot = false;
        }
    }
}
