using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_enemy : MonoBehaviour
{
    public int health = 2000;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Cat")
        {
            health -= 100;
            Destroy(col.gameObject);
            if(health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
