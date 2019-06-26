using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tower_mine : MonoBehaviour
{
    public int health = 2000;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "BossBear" || col.tag == "BossScorpion" || col.tag == "BossGiant")
        {
            health -= 100;
            Destroy(col.gameObject);
            if(health <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(5);
            }
        }
    }
}
