
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class badGuys1 : MonoBehaviour {
    public AudioClip hit;
    public AudioSource Hit;
    public Animator animator;
    public float maxhp = 40.0f;
    public float currenthp = 0;
    public GameObject healthBar;
    public bool isMoving = true;
    public float atackRate = 1;
    private float nextAtack;
    // Use this for initialization
    void Start () {
        currenthp = maxhp;
        Hit = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
       // TakeDamage(40);
	}


        public void TakeDamage(float d)
    {
        if (Time.time > nextAtack)
        {
            nextAtack = Time.time + atackRate;
            Hit.PlayOneShot(hit);
            currenthp -= d;
            float scaledhp = currenthp / maxhp;
            setHp(scaledhp);
            if (scaledhp <= 0.0f)
            {
                SceneManager.LoadScene(4);
                DieEnemy();

            }
        }
    }
    void DieEnemy()
    {
        Destroy(gameObject, 1f);
        animator.SetBool("Death", true);    
    }


    public void setHp(float myHp)
    {
        if (myHp < 0)
            myHp = 0;
        healthBar.transform.localScale = new Vector3(myHp, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }


}
