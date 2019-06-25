using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_module : MonoBehaviour
{
    protected int health;
    protected float speed;
    protected float weight;
    protected bool isEnemy;
    private float pos;

    public Cat_module(){
        health = 200;
        speed = 0.01f;
        weight = 100f;
        isEnemy = false;
    }

    protected void Move(bool isEnemy, float speed, float weight)
    {
        if(isEnemy)
        {
            gameObject.transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            gameObject.transform.position -= new Vector3(speed, 0, 0);
        }
    }

    protected void BeAttack(bool isEnemy, int health, float weight)
    {
        pos = -0.005f*(health + weight);
        if(isEnemy){
            gameObject.transform.position += new Vector3(pos, 0, 0);
        }
        else
        {
            gameObject.transform.position -= new Vector3(pos, 0, 0);
        }
    }
    protected void CheckIfDead(int health)
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
