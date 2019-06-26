using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HipHopCat : Cat_module
{
    public HipHopCat()
    {
        health = 150;
        speed  = 0.12f;
        weight = 100f;
    }
    
    void Update()
    {
        Move(speed, health);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Boss")
        {
            health -= 50;
            CheckIfDead(health);
            BeAttack(health, weight);
        }
    }
}
