using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
public class Tower_mine : MonoBehaviour
{
    public int health = 2000;
    public Text life_UI;


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "BossBear" || col.tag == "BossScorpion" || col.tag == "BossGiant")
        {
            health -= 100;
            life_UI.text = health+"";
            Destroy(col.gameObject);
            if(health <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(5);
            }
        }
    }
}
