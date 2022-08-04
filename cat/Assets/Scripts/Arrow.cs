﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-0.1f,0);

        if(transform.position.y<-5.0f){
            Destroy(gameObject);
        }
        Vector2 p1 =transform.position;
        Vector2 p2 =player.transform.position;
        Vector2 vec=p1-p2;
        float d=vec.magnitude;
        float r1=0.5f;
        float r2=1.0f;

        if(d<r1+r2){
            Destroy(gameObject);
            GameObject.FindObjectOfType<GameDirector>().DecreaseHp();
        }

    }
}
