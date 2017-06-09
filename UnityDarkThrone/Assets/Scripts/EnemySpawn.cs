﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public AudioClip enter;
    public AudioSource Enter;
    public Vector3 center;
    public Vector3 size;
    public GameObject Enemy;
    private float startWait;
    private int spawnWait;
	// Use this for initialization
	void Start () {
        StartCoroutine(waitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
        spawnWait = Random.Range(7,9);
        Enter.GetComponent<AudioSource>();
    }

    void spawn()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2),
            Random.Range(-size.y / 2, size.y / 2),
            Random.Range(-size.z / 2, size.z / 2));

        Instantiate(Enemy, pos, Quaternion.identity);
    }
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            Enter.PlayOneShot(enter);
            spawn();

            yield return new WaitForSeconds(spawnWait);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
