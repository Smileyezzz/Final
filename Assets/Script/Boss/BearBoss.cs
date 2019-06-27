using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearBoss : Boss_module
{
    public BearBoss()
    {
        health = 500;
        speed  = 0.09f;
        weight = 1000f;
    }

    void Update()
    {
        Move(speed, health);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "NormalCat")
        {
            health -= 50;
            CheckIfDead(health);
            BeAttack(health, weight);
        }

        if(col.tag == "AxeCat")
        {
            health -= 75;
            CheckIfDead(health);
            BeAttack(health, weight);
        }

        if(col.tag == "HipHopCat")
        {
            health -= 175;
            CheckIfDead(health);
            BeAttack(health, weight);
        }

        if(col.tag == "GrooseCat")
        {
            health -= 200;
            CheckIfDead(health);
            BeAttack(health, weight);
        }
    }
}
