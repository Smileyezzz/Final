using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCat : Cat_module
{
    public BadCat(){
        health = 200;
        speed = 0.1f;
        weight = 100f;
        isEnemy = true;
    }

    void Update()
    {
        Move(isEnemy, speed, health);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player2")
        {
            health -= 50;
            CheckIfDead(health);
            BeAttack(isEnemy, health, weight);
        }
    }

}
