using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : Money
{
    public Graphic image;
    public Button button;
    GameObject btn;

    void start()
    {
        button.gameObject.SetActive(false); 
        button.interactable = true;
        image.color = Color.green;
        InvokeRepeating("check",0f,0.1f);
    }
    void Update(){

    
    }  
    public void disable()
    {
        button.interactable = false;
        image.color = Color.red;
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        button.interactable = true;
        image.color = Color.green;
    }
    void check()
    {
        if( now_money() < 50) button.gameObject.SetActive(false); 
        else {button.gameObject.SetActive(true); }
    }
}
