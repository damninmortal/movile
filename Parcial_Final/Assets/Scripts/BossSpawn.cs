using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    public int maxEnemys;
    public GameObject spawnSite;
    public GameObject spawnSite2;
    private float rateIntern;
    private bool canSpawnEnemy = true;
    private bool canSpawnHorde = false;
    private GameObject[] enemyNum;
    public string tagSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyNum = GameObject.FindGameObjectsWithTag(tagSpawn);

        int num = enemyNum.Length;
        

        if (num == maxEnemys)
        {
            canSpawnHorde = false;
        }
        if (num == 0)
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

    }
    public void spawn(GameObject enemy,float rateSpawn)
    {        
        if (canSpawnHorde == true && canSpawnEnemy == true)
        {
            Instantiate(enemy, spawnSite.transform.position, enemy.transform.rotation);
            Instantiate(enemy, spawnSite2.transform.position, enemy.transform.rotation);
            rateIntern = rateSpawn;
            canSpawnEnemy = false;
          
        }
    }
}
