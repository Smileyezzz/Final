using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_module : MonoBehaviour
{
    protected int health;
    protected float speed;
    protected float weight;
    private float pos;

    protected void Move(float speed, float weight)
    {
        gameObject.transform.position -= new Vector3(speed, 0, 0);
    }

    protected void BeAttack(int health, float weight)
    {
        pos = -0.005f*(health + weight);
        gameObject.transform.position -= new Vector3(pos, 0, 0);
    }

    protected void CheckIfDead(int health)
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
