﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playPos=player.position;
        transform.position=new Vector3(
            transform.position.x,
            player.position.y,
            transform.position.z

        );

    }
}
