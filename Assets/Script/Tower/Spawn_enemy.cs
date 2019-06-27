using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_enemy : MonoBehaviour
{
    public GameObject Boss_1;
    private float time;
    private float crand;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = gameObject.transform.position + new Vector3(8f, 0, 0);
        Instantiate(Boss_1, pos, transform.rotation);
        crand =delay_time();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > crand){
            Vector3 pos = gameObject.transform.position + new Vector3(8f, 0, 0);
            Instantiate(Boss_1, pos, transform.rotation);
            time = 0;
            crand =delay_time();
        }
    }

    private float delay_time(){
        float r = Random.value;
        float cra= 10 * r;
        print(cra);
        return cra;
    }
}