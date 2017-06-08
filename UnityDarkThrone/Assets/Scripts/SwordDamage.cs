﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamage : MonoBehaviour
{
    public GameObject player;
    private GameObject badguy;


     void OnTriggerStay(Collider enemy)
    {
        if (enemy.CompareTag("Enemy"))
        {
            badguy = enemy.gameObject;
            Attack();
        }
    }

    void Attack()
    {
        badGuys bg = badguy.GetComponent<badGuys>();
        if (player.GetComponent<playerController>().isAtacking)
        {
            bg.TakeDamage(20);
            player.GetComponent<playerController>().isAtacking = false;
        }
        
    }
}