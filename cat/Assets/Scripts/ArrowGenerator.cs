using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    Vector2 ang = Vector2.zero;
    public GameObject prefab;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            ang.x = 1f;
            GameObject obj = Instantiate(
         prefab,
                 new Vector3(Random.Range(-6f, 6f), 7f, 0),
         Quaternion.identity
         );

            int px = Random.Range(-6, 7);
            obj.transform.position = new Vector3(px, 7, 0);
        }
        //StartCoroutine(Move());

    }

    // Update is called once per frame
    void Update()
    {
        /*this.delta+=Time.deltaTime;
        if(this.delta>this.span){
            this.delta=0;
            GameObject obj=Instantiate(
                prefab,
                new Vector3(Random.Range(-6f,6f),7f,0),
                Quaternion.identity
                );

            int px=Random.Range(-6,7);
            obj.transform.position=new Vector3(px,7,0);

        }*/

    }
    /*IEnumerator Move()
    {
        while(true){
        yield return new WaitForSeconds(1f);
        ang.x = 1f;
        GameObject obj = Instantiate(
     prefab,
             new Vector3(Random.Range(-6f, 6f), 7f, 0),
     Quaternion.identity
     );

        int px = Random.Range(-6, 7);
        obj.transform.position = new Vector3(px, 7, 0);
    }
    }*/
}
