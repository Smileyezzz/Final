using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCat : Cat_module
{
    int health = 200;
    float speed = 0.1f;
    float weight = 100f;
    bool isEnemy = true;

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
