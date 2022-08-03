using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    public  CandyManager candyManager;
    public int reward;
    public GameObject effecrPrefab;
    public Vector3 effectRotation;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Candy")
        {
            candyManager.AddCandy(reward);

            Destroy(other.gameObject);

            if(effecrPrefab !=null)
            {
                Instantiate(
                    effecrPrefab,
                    other.transform.position,
                    Quaternion.Euler(effectRotation)
                );
            }
        }
    }

}
