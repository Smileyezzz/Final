using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodCat : Cat_module
{
    public GoodCat(){
        health = 250;
        speed = 0.07f;
        weight = 200f;
        isEnemy = false;
    }

    void Update()
    {
        Move(isEnemy, speed, health);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            health -= 50;
            CheckIfDead(health);
            BeAttack(isEnemy, health, weight);
        }
    }
}
