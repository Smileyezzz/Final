using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tower_enemy : MonoBehaviour
{
    public int health = 2000;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "AxeCat" || col.tag == "NormalCat" || col.tag == "GrooseCat" || col.tag == "HipHopCat")
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
