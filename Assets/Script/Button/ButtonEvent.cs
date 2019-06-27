using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : Money
{
    public Graphic image;
    public Button button;
    public int cost; 
    private bool flag = true;
    GameObject btn;

    void start()
    {
        button.gameObject.SetActive(false); 
        button.interactable = true;
        image.color = Color.red;

    }
    void Update()
    {
        if(flag)
            Check();
    }  

    public void disable()
    {
        flag = false;
        button.interactable = false;
        image.color = Color.red;
        StartCoroutine(Delay());

    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        button.interactable = true;
        image.color = Color.green;
        flag = true;
    }

    void Check()
    {
        if(now_money() < cost) 
        {
            button.interactable = false;
            image.color = Color.red;
        }
        else 
        {
            button.interactable = true;
            image.color = Color.green;
        }
    }
}
