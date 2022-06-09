using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float rateSpawn;
    public int maxEnemys;
    private float rateIntern;
    private bool canSpawnEnemy=true;
    private bool canSpawnHorde=false;
    private GameObject[] enemyNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyNum = GameObject.FindGameObjectsWithTag(enemy.tag);
       
        int num = enemyNum.Length;
        
        if (num==maxEnemys)
        {
            canSpawnHorde = false;
        }
        if (num==0)
        {
            canSpawnHorde = true;
        }
            spawn();
            if (canSpawnEnemy == false)
            {
                rateIntern -= 1 * Time.deltaTime;
                if (rateIntern <= 0)
                {
                    canSpawnEnemy = true;
                }
            }
        
       
    }
    public void spawn()
    {
        if (canSpawnHorde == true && canSpawnEnemy == true)
        {
                Instantiate(enemy, transform.position, enemy.transform.rotation);
                rateIntern = rateSpawn;
                canSpawnEnemy = false;
        }
    }
}
