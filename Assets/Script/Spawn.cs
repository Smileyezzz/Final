using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Cat_Normal;
    public GameObject Cat_Axe;
    public GameObject Cat_HipHop;
    public GameObject Cat_Groose;
    public GameObject Tower;

    public void Produce_Normal()
    {
        Vector3 pos = Tower.transform.position + new Vector3(-5f, -2.2f, 0);
        Instantiate(Cat_Normal, pos, Tower.transform.rotation);
    }

    public void Produce_Axe()
    {
        Vector3 pos = Tower.transform.position + new Vector3(-5f, -2.2f, 0);
        Instantiate(Cat_Axe, pos, Tower.transform.rotation);
    }

    public void Produce_HipHop()
    {
        Vector3 pos = Tower.transform.position + new Vector3(-5f, -2.2f, 0);
        Instantiate(Cat_HipHop, pos, Tower.transform.rotation);
    }

    public void Produce_Groose()
    {
        Vector3 pos = Tower.transform.position + new Vector3(-5f, -2.2f, 0);
        Instantiate(Cat_Groose, pos, Tower.transform.rotation);
    }
}
