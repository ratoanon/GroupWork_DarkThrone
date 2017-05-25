using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badGuys : MonoBehaviour {
    public float hp = 40.0f;
    // Use this for initialization
    void Start () {
		
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


}
