using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCat : Cat_module
{
    public AxeCat()
    {
        health = 200;
        speed  = 0.04f;
        weight = 600f;
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
