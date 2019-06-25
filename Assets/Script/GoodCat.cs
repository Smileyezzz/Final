using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodCat : Cat_module
{
    int health = 250;
    float speed = 0.07f;
    float weight = 200f;
    bool isEnemy = false;

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
