using System.Collections;
using System.Collections.Generic;
using System.Text;
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
            if (AA == null)
            {
                AA = StartCoroutine(change_color());
            }
        }

        else if(Input.GetKey(KeyCode.Escape))
        {
            if (AA != null)
            {
                StopCoroutine(AA);
                AA = null;
            }
        }
       
    }

    IEnumerator change_color()
    {

       Color mycolor = new Color(0.0001f, 0.0001f, 0.0001f, 0.0f);

        while(true)
        {
            if (mysr.color.r == 0)
            {
                Debug.Log("에볼루션 컴플리트");
                AA = null;
                yield break;
            }

            mysr.color -= mycolor;
            yield return null;

        }
    }
}
