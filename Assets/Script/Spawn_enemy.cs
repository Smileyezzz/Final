using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_enemy : MonoBehaviour
{
    public GameObject Boss_1;
    public GameObject Boss_2;
    public GameObject Boss_3;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 2f)
        {
            Vector3 pos = gameObject.transform.position + new Vector3(8f, 0, 0);
            Instantiate(Boss_1, pos, transform.rotation);
            time = 0;
        }
    }
}
