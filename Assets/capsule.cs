using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule : MonoBehaviour
{
    SpriteRenderer mysr;
    // Start is called before the first frame update
    void Start()
    {
        mysr = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
                {
            InvokeRepeating("change_color",0.5f,1.0f);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            CancelInvoke("change_color");
        }
    }

    void change_color()
    {
        mysr.color=new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f));

    }
}
