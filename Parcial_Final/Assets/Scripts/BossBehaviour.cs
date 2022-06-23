using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    //Class
    private BossHealth health;
    private BossShot shot;
    private BossMove move;
    private BossSpawn spawn;

    //Health
    private float overallHealth;

    //Move
    public float speedMovement;

    //SpawnMinions
    public float rateSpawn;
    public int maxEnemies;
    public GameObject minion1;
    public GameObject minion2;
    public GameObject minion3;
    public string tagM;

    //Shot
    public float rateFire;
    public GameObject projectile1;
    public GameObject projectile2;
    public GameObject projectile3;
    public GameObject sProjectile;



    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<BossHealth>();
        shot = GetComponent<BossShot>();
        move = GetComponent<BossMove>();
        spawn = GetComponent<BossSpawn>();

        move.speed = speedMovement;
        overallHealth = health.healthValue;

    }

    // Update is called once per frame
    void Update()
    {
        if (health.healthValue<=overallHealth && health.healthValue>=overallHealth*0.75f)
        {
            spawn.tagSpawn = minion1.tag;
            spawn.maxEnemys = maxEnemies;
            spawn.spawn(minion1, rateSpawn);
            shot.Attack(projectile1,1.75f);
            move.fase = 1;
            //Debug.Log(health.healthValue + " - " + overallHealth * 0.75f);
        }else
        if (health.healthValue<=overallHealth*0.75f && health.healthValue>=overallHealth*0.5f)
        {
            spawn.tagSpawn = minion2.tag;
            spawn.maxEnemys = 2;
            spawn.spawn(minion2, rateSpawn);
            shot.Attack(projectile2, 2.25f);
            move.fase = 2;
            //Debug.Log(health.healthValue + " - " + overallHealth * 0.5f);
        }
        else
        if (health.healthValue <= overallHealth * 0.5f && health.healthValue >= overallHealth * 0.25f)
        {
            spawn.tagSpawn = minion2.tag;
            spawn.maxEnemys = 2;
            spawn.spawn(minion2, rateSpawn);
            shot.AttackFase3(projectile3, 0.3f);
            move.fase = 3;
            // Debug.Log(health.healthValue + " - " + overallHealth * 0.25f);
        }
        else
        if (health.healthValue <= overallHealth * 0.25f)
        {
            spawn.tagSpawn = minion3.tag;
            spawn.maxEnemys = 2;
            spawn.spawn(minion3, rateSpawn);
            shot.AttackFase3(projectile3, 0.3f);
            move.fase = 4;
            // Debug.Log(health.healthValue + " - " + overallHealth * 0f);
        }

    }
    
        
}
