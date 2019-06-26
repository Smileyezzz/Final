using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI; 



public class Money : MonoBehaviour{
    protected static int money;
    public Money(){
        money = 0;
    }
   // public static Money Instance;

    public Text time_UI;

    void Start(){

        InvokeRepeating("timer",0f,0.1f);         
  	}

    void timer(){

        money += 1;
        gameObject.GetComponent<Text>().text = money.ToString();
        //CancelInvoke("timer"); //stop the time
	}
    public int now_money(){
        return money;
    }
    public void money_set(int m){
        money = m;
    }

}