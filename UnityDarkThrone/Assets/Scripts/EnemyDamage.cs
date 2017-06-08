using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject badguy;
    private GameObject player1;


    void OnTriggerStay(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            player1 = player.gameObject;
            AttackPlayer();
        }
    }

    void AttackPlayer()
    {
        playerController pl = player1.GetComponent<playerController>();
       // if (player1.GetComponent<playerController>().isAtacking)
       // {
            pl.TakeDamage(20);
       //     player1.GetComponent<playerController>().isAtacking = false;
      //  }

    }
}