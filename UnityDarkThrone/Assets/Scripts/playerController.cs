using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private Animator animator;
    public float speed = 1f;
    private float health = 100f;

	// Use this for initialization  
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        playerMove();
	}

    void playerMove()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);

        if (Input.GetAxis("Vertical") > 0)  //W
            animator.SetBool("walk", true);
        else animator.SetBool("walk", false);
        if (Input.GetAxis("Vertical") < 0)  //S
            animator.SetBool("walkback", true);
        else animator.SetBool("walkback", false);


        if (Input.GetAxis("Horizontal") > 0)  //D
            animator.SetBool("strafe", true);
        else animator.SetBool("strafe", false);
        if (Input.GetAxis("Horizontal") < 0)  //A
            animator.SetBool("strafeleft", true);
        else animator.SetBool("strafeleft", false);

        if (Input.GetMouseButtonDown(0))  //left mouse --attack
        {
            animator.SetTrigger("slash");
            speed = 0.4f; // atrasar quando ataca
        }
        // else speed = 3f;  needs fixin'
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
}

 