using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamge : MonoBehaviour
{
    public GameObject player1;
    private GameObject badguy1;


    void OnTriggerStay(Collider enemy)
    {
        if (enemy.CompareTag("Player"))
        {
            badguy1 = enemy.gameObject;
            Attack1();
        }
    }

    void Attack1()
    {
        badGuys bg = badguy1.GetComponent<badGuys>();
        if (player1.GetComponent<playerController>().isAtacking)
        {
            bg.TakeDamage(20);
            player1.GetComponent<playerController>().isAtacking = false;
        }

    }
}