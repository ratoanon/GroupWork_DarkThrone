using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public Animator animator;
    private float speed = 3f;
    private float health = 100f;
    public bool isAtacking = false;
    // Use this for initialization  
    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
    }

    void playerMove()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);

        if (Input.GetAxis("Vertical") > 0)  //W
        {
            animator.SetBool("walk", true);
            if ((Input.GetAxis("Vertical") > 0) && (Input.GetKeyDown("space"))) // ROLL FORWARD
            {
                animator.SetBool("frontroll", true);
                speed = 5f;
            }
            else animator.SetBool("frontroll", false); //speed = 3f; 

        }
        else animator.SetBool("walk", false);


        if (Input.GetAxis("Vertical") < 0)  //S
        { animator.SetBool("walkback", true);
            if ((Input.GetAxis("Vertical") < 0) && (Input.GetKey("space"))) //RUN BACK
            {
                animator.SetBool("runback", true);
                speed = 5f;
            }
            else animator.SetBool("runback", false);
        }
        else animator.SetBool("walkback", false);


        if (Input.GetAxis("Horizontal") > 0)  //D
        { animator.SetBool("strafe", true);
            if ((Input.GetAxis("Horizontal") > 0) && (Input.GetKey("space"))) //RUN LEFT
            {
                animator.SetBool("runleft", true);
                speed = 5f;
            }
            else animator.SetBool("runleft", false);
        }
        else animator.SetBool("strafe", false);


        if (Input.GetAxis("Horizontal") < 0)  //A
        {
            animator.SetBool("strafeleft", true);
            if ((Input.GetAxis("Horizontal") < 0) && (Input.GetKey("space"))) //RUN RIGHT
            {
                animator.SetBool("runright", true);
                speed = 5f;
            }
            else animator.SetBool("runright", false);
        }
        else animator.SetBool("strafeleft", false);

        if (Input.GetMouseButtonDown(0))  //left mouse --attack
        {
            animator.SetTrigger("slash");
            speed = 0.4f; // atrasar quando ataca
            isAtacking = true;
            Invoke("cancelAtack", 1.2f);
        }
        // else speed = 3f;  needs 0fixin'
        if (Input.GetMouseButtonDown(1))  // right mouse attack
        {
            animator.SetTrigger("slashup");
            speed = 0.4f;
        }

    }

    public void TakeDamage(float dd)
    {
        health -= dd;
        
    }

    void cancelAtack()
    {
        speed = 3f;
        isAtacking = false;
    }
}

 