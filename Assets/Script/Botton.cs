using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botton : MonoBehaviour
{
    public Button Button1;

    // Start is called before the first frame update
    void Start()
    {
        Button1.onClick.AddListener(Button1Clicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
