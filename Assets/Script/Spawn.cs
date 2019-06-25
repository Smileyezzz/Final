using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Cat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            Vector3 pos = gameObject.transform.position + new Vector3(-5f, -1.8f, 0);
            Instantiate(Cat, pos, gameObject.transform.rotation);
        }
    }
}
