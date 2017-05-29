
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badGuys : MonoBehaviour {
    public float maxhp = 40.0f;
    public float currenthp = 0;
    public GameObject healthBar;
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
            DieEnemy();
        }
    }
    void DieEnemy()
    {
        Destroy(gameObject, 1f);
    }

    public void setHp(float myHp)
    {
        healthBar.transform.localScale = new Vector3(myHp, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }


}
