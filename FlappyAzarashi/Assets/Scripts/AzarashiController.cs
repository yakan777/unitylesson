using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzarashiController : MonoBehaviour
{
    Rigidbody2D rcb2d;
    Animator animator;
    float angle;
    bool isDead;

    public float maxHeight;
    public float flapVelocity;
    public float relativeVelocityX;
    public GameObject sprite;
    // Start is called before the first frame update
    public bool IsDead()
    {
        return isDead;
    }
    void Awake()
    {
        rcb2d=GetComponent<Rigidbody2D>();
        animator=sprite.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")&& transform.position.y<maxHeight)
        {
            Flap();
        }
        ApplyAngle();

        animator.SetBool("flap",angle>=0.0f && !isDead);

    }
    public void Flap()
    {
        if(isDead) return;

        if(rcb2d.isKinematic)return;

        rcb2d.velocity=new Vector2(0.0f,flapVelocity);
    }
    void ApplyAngle()
    {
        float targetAngle;

        if(isDead)
        {
            targetAngle=180.0f;
        }
        else
        {

        targetAngle=
        Mathf.Atan2(rcb2d.velocity.y,relativeVelocityX)*Mathf.Rad2Deg;
        }
        angle=Mathf.Lerp(angle,targetAngle,Time.deltaTime*10.0f);

        sprite.transform.localRotation=Quaternion.Euler(0.0f,0.0f,angle);

    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(isDead)return;

        isDead =true;

    }

    public void SetSteerAvtive(bool active)
    {
        rcb2d.isKinematic=!active;
    }
}
