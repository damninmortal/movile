using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float rateSpawn;
    public int maxEnemys;
    public int typeEnemy;
    public EnemyManager manager;
    private float rateIntern;
    private bool canSpawnEnemy=true;
    private bool canSpawnHorde=false;
    private int enemyNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyNum = GetComponentsInChildren<EnemyHealth>().Length;
      

        if (enemyNum==maxEnemys)
        {
            canSpawnHorde = false;
        }
        if (enemyNum==0)
        {
            canSpawnHorde = true;
        }
           
            if (canSpawnEnemy == false)
            {
                rateIntern -= 1 * Time.deltaTime;
                if (rateIntern <= 0)
                {
                    canSpawnEnemy = true;
                }
            }
        spawn();

    }
    public void spawn()
    {
        if (canSpawnHorde == true && canSpawnEnemy == true)
        {
            GameObject inst;
            inst= Instantiate(enemy, transform.position, enemy.transform.rotation);
            inst.transform.parent = transform;
            Numsum(typeEnemy);
            rateIntern = rateSpawn;
            canSpawnEnemy = false;
        }
    }
    public void Numsum(int typ)
    {
        switch (typ)
        {
            case 1:
                manager.enemy1Spawn++;
                break;
            case 2:
                manager.enemy2Spawn++;
                break;
            case 3:
                manager.enemy3Spawn++;
                break;
            default:
                break;
        }
    }
}
