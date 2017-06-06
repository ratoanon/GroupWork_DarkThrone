using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadBoss : MonoBehaviour {

    public GameObject player;
    private GameObject gate;

    void OnTriggerEnter (Collider door)
    {
        SceneManager.LoadScene(2);
    } 

  
}
