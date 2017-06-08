
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class badGuys1 : MonoBehaviour {

    public Animator animator;
    public float maxhp = 40.0f;
    public float currenthp = 0;
    public GameObject healthBar;
    public bool isMoving = true;
    // Use this for initialization
    void Start () {
        currenthp = maxhp;
    }
	
	// Update is called once per frame
	void Update () {
       // TakeDamage(40);
	}


        public void TakeDamage(float d)
    {
        currenthp -= d;
        float scaledhp = currenthp / maxhp; 
        setHp(scaledhp);
        if (scaledhp <= 0.0f)
        {
            SceneManager.LoadScene(4);
            DieEnemy();

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
