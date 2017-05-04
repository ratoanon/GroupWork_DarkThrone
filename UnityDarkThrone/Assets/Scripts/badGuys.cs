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
        hp -= d;
        if (hp <= 0.0f)
        {
            DieEnemy();
        }
    }
    void DieEnemy()
    {
        Destroy(gameObject, 1f);
    }


}
