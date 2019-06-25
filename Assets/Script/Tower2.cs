using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower2 : MonoBehaviour
{
    int health = 2000;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player2")
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
