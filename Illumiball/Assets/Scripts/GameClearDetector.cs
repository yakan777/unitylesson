﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearDetector : MonoBehaviour
{
    public Hole holeRed;
    public Hole holeBlue;
    public Hole holeGreen;
    void OnGUI()
    {
        GUI.matrix=Matrix4x4.Scale(Vector3.one*2);
        if(holeRed.IsHolding()&&holeBlue.IsHolding()&&holeGreen.IsHolding()){
            GUI.Label(new Rect(50,50,100,30),"Game Clear!");
        }

    }
}
