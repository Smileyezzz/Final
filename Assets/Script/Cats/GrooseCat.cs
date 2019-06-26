using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrooseCat : Cat_module
{
    public GrooseCat()
    {
        health = 350;
        speed  = 0.10f;
        weight = 300f;
    }

    void Update()
    {
        Move(speed, health);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "BossBear")
        {
            health -= 50;
            CheckIfDead(health);
            BeAttack(health, weight);
        }

        if(col.tag == "BossScorpion")
        {
            health -= 75;
            CheckIfDead(health);
            BeAttack(health, weight);
        }

        if(col.tag == "BossGiant")
        {
            health -= 100;
            CheckIfDead(health);
            BeAttack(health, weight);
        }

    }
}
