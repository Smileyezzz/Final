using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantBoss : Boss_module
{
    public GiantBoss()
    {
        health = 220;
        speed  = 0.04f;
        weight = 600f;
    }

    void Update()
    {
        Move(speed, health);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Cat")
        {
            health -= 50;
            CheckIfDead(health);
            BeAttack(health, weight);
        }
    }
}
