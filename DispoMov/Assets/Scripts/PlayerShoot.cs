using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject meleeArea;
    [SerializeField] private float speed;
    [SerializeField] private Transform spawn;
    [SerializeField] private Transform areaMelee;
    [SerializeField] private float rateFire;
    private float rateIntern;
    [SerializeField] private float rangeRayCast;
    private bool canShoot = true;
    [SerializeField] private bool Instantiate;
    [SerializeField] private bool rayCast;
    [SerializeField] private bool melee;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot==false)
        {
            rateIntern -= 1 * Time.deltaTime;
          //  Debug.Log("descansando");
            if (rateIntern<=0)
            {
                canShoot = true;
           //     Debug.Log("descanse");
            }
        }
    }
    public void attack()
    {
       
        if (canShoot==true && Instantiate==true)
        {
            GameObject instProjectile = Instantiate(projectile,
                spawn.position, projectile.transform.rotation);
            Rigidbody2D projectileRB = instProjectile.GetComponent<Rigidbody2D>();
            projectileRB.velocity = transform.right * speed;
            rateIntern = rateFire;
            canShoot = false;
       //     Debug.Log("disparo"+rateFire+"  "+rateIntern);
        }
        if (canShoot==true && rayCast==true)
        {
            rateIntern = rateFire;
            canShoot = false;
            RaycastHit2D hit2D = Physics2D.Raycast(spawn.position,transform.right,rangeRayCast);
            Debug.DrawRay(spawn.position,transform.right,Color.green);
            Debug.Log(hit2D.collider.name);
            Debug.Log("exito");
        }
        if (canShoot==true && melee==true)
        {
            Instantiate(meleeArea,
                areaMelee.position, projectile.transform.rotation);
            
            //Destroy(meleeArea, rateFire - 1.0f);
            rateIntern = rateFire;
            canShoot = false;
        }
        else
        {
           // Debug.Log("no puedo");
        }
      
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(spawn.position,transform.right*rangeRayCast);
    }
}
