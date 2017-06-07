using UnityEngine;
using System.Collections;

public class EnemyFollows : MonoBehaviour
{

    UnityEngine.AI.NavMeshAgent agent;
    GameObject player;
    public playerController playerC;
    Transform  movep;
    float speed = 1.5f;
    float rot = 3f;


    void Start()
    {
        movep = player.transform;
    }

    // Use this for initialization
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation
                                       , Quaternion.LookRotation(movep.position - transform.position)
                                       , rot * Time.deltaTime);

        Vector3 move = movep.position - transform.position;
            move.Normalize();
            transform.position += move * speed * Time.deltaTime;
    }
}
