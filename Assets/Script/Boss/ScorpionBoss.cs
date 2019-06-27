using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorpionBoss : Boss_module
{
    public ScorpionBoss()
    {
        health = 1000;
        speed  = 0.03f;
        weight = 1250f;
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
            health -= 200;
            CheckIfDead(health);
            BeAttack(health, weight);
        }

        if(col.tag == "GrooseCat")
        {
            health -= 250;
            CheckIfDead(health);
            BeAttack(health, weight);
        }
    }
}
