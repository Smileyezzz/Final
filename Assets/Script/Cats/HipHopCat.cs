using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HipHopCat : Cat_module
{
    public HipHopCat()
    {
        health = 150;
        speed  = 0.12f;
        weight = 180f;
    }
    
    void Update()
    {
        Move(speed, health);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "BossBear")
        {
            health -= 75;
            CheckIfDead(health);
            BeAttack(health, weight);
        }

        if(col.tag == "BossScorpion")
        {
            health -= 150;
            CheckIfDead(health);
            BeAttack(health, weight);
        }

        if(col.tag == "BossGiant")
        {
            health -= 300;
            CheckIfDead(health);
            BeAttack(health, weight);
        }

    }
}
