//Timeクラスの重要プロパティ
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.frameCount % 30 == 0){
            Debug.Log("time:"+Time.time);//ゲームが始まってからの時間
            Debug.Log("FrameCount:"+Time.frameCount);//フレームカウント
            Debug.Log("deltaTime:"+Time.deltaTime);//直前フレームにかかった時間
            Debug.Log("timeScale:"+Time.timeScale);//時間のスケール（通常は1)
        }

    }
}