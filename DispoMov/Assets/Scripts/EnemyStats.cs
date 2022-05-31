using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    [SerializeField] private float life = 1f;
    [SerializeField] private Image lifeBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeBar.fillAmount = life;
    }
    public void ReceivedDamage(float damage)
    {
        life -=(damage / 100);
    }
}
