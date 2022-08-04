﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour
{
    public float speed =1.0f;
    public float startPosition;
    public float endPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1*speed*Time.deltaTime,0,0);

        if(transform.position.x<=endPosition)ScrollEnd();

    }
    void ScrollEnd()
    {
        float diff=transform.position.x-endPosition;
        Vector3 restartPosition=transform.position;
        restartPosition.x=startPosition+diff;
        transform.position=restartPosition;

        SendMessage("OnScrollEnd",SendMessageOptions.DontRequireReceiver);

    }
}
