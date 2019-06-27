using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantBoss : Boss_module
{
    public GiantBoss()
    {
        health = 1000;
        speed  = 0.1f;
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
            health -= 40;
            CheckIfDead(health);
            BeAttack(health, weight);
        }

        if(col.tag == "AxeCat")
        {
            health -= 60;
            CheckIfDead(health);
            BeAttack(health, weight);
        }

        if(col.tag == "HipHopCat")
        {
            health -= 150;
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
