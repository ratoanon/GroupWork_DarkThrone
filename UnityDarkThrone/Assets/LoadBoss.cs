using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadBoss : MonoBehaviour {

    public GameObject player;
    private GameObject gate;

    void OnTriggerStay (Collider door)
    {
            if (door.CompareTag("door"))
            {
                gate = door.gameObject;
                Load();
        }
    } 

    public void Load()
    {
       
        if (player.GetComponent<playerController>().isAtacking)
        { SceneManager.LoadScene(2); }
    }
}
