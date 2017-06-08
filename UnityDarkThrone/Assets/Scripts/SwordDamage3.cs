using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamage3 : MonoBehaviour
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
        badGuys1 bg = badguy.GetComponent<badGuys1>();
        if (player.GetComponent<playerController>().isAtacking2)
        {
            bg.TakeDamage(20);
            player.GetComponent<playerController>().isAtacking2 = false;
        }
    }
}