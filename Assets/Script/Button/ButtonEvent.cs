using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    public Graphic image;
    public Button button;

    void start()
    {
        button.interactable = true;
        image.color = Color.green;
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
}
