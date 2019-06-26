using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrooseCat : Cat_module
{
    public GrooseCat()
    {
        health = 250;
        speed  = 0.07f;
        weight = 200f;
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
