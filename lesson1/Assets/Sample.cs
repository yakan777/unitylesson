using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    int n = 0;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start in!");
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        n++;
        Debug.Log(n);
        */
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(ball);
        }
    }
}
