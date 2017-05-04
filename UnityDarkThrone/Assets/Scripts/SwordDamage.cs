using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamage : MonoBehaviour
{
    public GameObject badguy;

    public bool isAttacking;

    // Use this for initialization
    void Start()
    {
        badguy = GameObject.FindGameObjectWithTag("Enemy");
        isAttacking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAttacking)
        {
                Attack();
        }
    }

     void OnTriggerEnter(Collider enemy)
    {
        Debug.Log("gvhgfhgfh");
        if (enemy.CompareTag("Enemy"))
        {
            //badGuys bguy = enemy.GetComponent<badGuys>();
            isAttacking = true;
        }
    }

    void OnTriggerExit(Collider enemy)
    {
        if (enemy.CompareTag("Enemy"))
        {
            isAttacking = false;
        }
    }

    void Attack()
    {
        badGuys bg = badguy.GetComponent<badGuys>();
        bg.TakeDamage(40);
    }
}