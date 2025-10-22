using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{

    SpriteRenderer mysr;
    Coroutine AA;
    // Start is called before the first frame update
    void Start()
    {
        mysr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            AA = StartCoroutine("change_color");
        }

        else if(Input.GetKey(KeyCode.Escape))
        {
            StopCoroutine(AA);
        }
    }

    IEnumerator change_color()
    {
        yield return null;
        mysr.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

    }
}
