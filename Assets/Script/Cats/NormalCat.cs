using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalCat : Cat_module
{
    public NormalCat()
    {
        health = 180;
        speed  = 0.05f;
        weight = 280f;
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
