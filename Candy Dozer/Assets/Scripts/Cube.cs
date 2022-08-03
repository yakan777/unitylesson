using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Vector3 ang=Vector3.zero;
    IEnumerator co;
    // Start is called before the first frame update
    void Start()
    {
        co=Move();
        StartCoroutine(co);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(ang);
        if(Input.GetMouseButtonDown(0)){
            StopCoroutine(co);
        }
        if(Input.GetMouseButtonDown(1)){
            co=null;
            co=Move();
            StartCoroutine(co);
        }

    }

    IEnumerator Move(){
        yield return new WaitForSeconds(2f);
        ang.x = 2f;
        yield return new WaitForSeconds(5f);
        ang.x = 0;
        ang.y = 2f;
        yield return new WaitForSeconds(5f);
        ang = new Vector3(1f,1f,1f);

    }
}