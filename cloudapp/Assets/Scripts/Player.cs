using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    float jumpForce=680f;
    float walkForce=30f;
    float maxWalkSpeed=2f;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        animator=GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")&& rb.velocity.y==0){
            animator.SetTrigger("JumpTrigger");
            rb.AddForce(transform.up*jumpForce);
        }
        float speedx=Mathf.Abs(rb.velocity.x);
        float dir=Input.GetAxisRaw("Horizontal");
        if(speedx<maxWalkSpeed){
            rb.AddForce(transform.right*dir*walkForce);
        }
        if(dir !=0){
            transform.localScale=new Vector3(dir,1f,1f);
        }
        if(rb.velocity.y==0){
            animator.speed=speedx /2.0f;

        }else{
            animator.speed=1f;

        }
        if(transform.position.y<-10){
            SceneManager.LoadScene("Main");
        }

    }
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log(other.gameObject.name);
        Debug.Log("ゴール");
        SceneManager.LoadScene("ClearScene");
    }
}
