using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld2 : MonoBehaviour
{
    SpriteRenderer mySR;
    // Start is called before the first frame update
    void Start()
    {
        mySR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            change_color();
        }
            
        
    }
    void change_color()
    {
        mySR.color = Color.blue;
    }
}
