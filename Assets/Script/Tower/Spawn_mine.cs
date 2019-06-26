using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_mine : Money
{
    public GameObject Cat_Normal;
    public GameObject Cat_Axe;
    public GameObject Cat_HipHop;
    public GameObject Cat_Groose;
    public GameObject Tower;
    

    public void Produce_Normal()
    {
        Vector3 pos = Tower.transform.position + new Vector3(-5f, -6f, 0);
        if(If_prduce(10)) 
            Instantiate(Cat_Normal, pos, Tower.transform.rotation);

    }

    public void Produce_Axe()
    {
        Vector3 pos = Tower.transform.position + new Vector3(-5f, -6f, 0);
        if(If_prduce(30)) 
            Instantiate(Cat_Axe, pos, Tower.transform.rotation);
    }

    public void Produce_HipHop()
    {
        Vector3 pos = Tower.transform.position + new Vector3(-5f, -4.5f, 0);
        if(If_prduce(50)) 
            Instantiate(Cat_HipHop, pos, Tower.transform.rotation);
    }

    public void Produce_Groose()
    {
        Vector3 pos = Tower.transform.position + new Vector3(-5f, -4.5f, 0);
        if(If_prduce(100)) 
            Instantiate(Cat_Groose, pos, Tower.transform.rotation);
    }
    /*
     private bool If_prduce(int cost){
        int m =  base.money; 
        if( m > cost)
        {       base.money-= base.money ;
                return true;
        }
        return false;
    }
    
    */
    private bool If_prduce(int cost){
        int m =  now_money(); 
        if( m > cost)
        {       m -= cost ;
                money_set (m);
                return true;
        }
        return false;
    }
}
