using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Health_register : MonoBehaviour
{

    public float Damage_Num = 1;

    public float health = 10;

    private float health_orgin;

    private static Player_Movement _instance;

    [SerializeField]
    private TextMeshProUGUI healthLabel;
    // Start is called before the first frame update
    void Start()
    {
        health_orgin = health;
        healthLabel.text = "Health:" + health.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Health_point(float damage)
    {
        print("works?");
        if (health >= 0) { 
        health -= damage;
        healthLabel.text = "Health:" + health.ToString();
        }
        else
        {
            if(health <= 0)
            {
                healthLabel.text = "Death:";
            }
        }
    }
}
   
