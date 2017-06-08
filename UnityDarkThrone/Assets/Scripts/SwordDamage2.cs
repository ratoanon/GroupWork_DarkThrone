using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamage2 : MonoBehaviour
{
    public GameObject player;
    private GameObject badguy;
    private GameObject badguyB;

    void OnTriggerStay(Collider enemy)
    {
        if (enemy.CompareTag("Enemy"))
        {
            badguy = enemy.gameObject;
            badguyB = enemy.gameObject;
            Attack();
        }
    }

    void Attack()
    {
        badGuys bg = badguy.GetComponent<badGuys>();
        if (player.GetComponent<playerController>().isAtacking2)
        {
            bg.TakeDamage(20);
            player.GetComponent<playerController>().isAtacking2 = false;
        }

        badGuys bgB = badguyB.GetComponent<badGuys>();
        if (player.GetComponent<playerController>().isAtacking2)
        {
            bgB.TakeDamage(20);
            player.GetComponent<playerController>().isAtacking2 = false;
        }



    }
}