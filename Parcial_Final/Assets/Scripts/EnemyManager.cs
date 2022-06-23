using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int enemy1Total;
    public int enemy2Total;
    public int enemy3Total;
    public int enemy1Spawn;
    public int enemy2Spawn;
    public int enemy3Spawn;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public Panel panel;
    public bool boss;
    public int restantes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int sumtotal = enemy1Total + enemy2Total + enemy3Total;
        int sumSpawn = enemy1Spawn + enemy2Spawn + enemy3Spawn;
        if (enemy1Spawn==enemy1Total-restantes)
        {
            spawn2.SetActive(true);
            spawn3.SetActive(true);
        }
        if (enemy1Total<=enemy1Spawn)
        {
            Destroy(spawn1);
        }
        if (enemy2Total <= enemy2Spawn)
        {
            Destroy(spawn2);
        }
        if (enemy3Total <= enemy3Spawn)
        {
            Destroy(spawn3);
        }
        if (sumtotal==sumSpawn && boss==false)
        {
            StartCoroutine(FinishLevel());
        }

    }
    IEnumerator FinishLevel()
    {
        yield return new WaitForSeconds(3);
        panel.Next();
    }
}
