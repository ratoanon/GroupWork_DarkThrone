using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    CharacterController player;
    public float speed = 13f;
    private Rigidbody rig;
    private Transform playerT;
    public GameObject eyes;
    private float mouseX, mouseY;
    Vector3 movement;

    // Use this for initialization
    void Start () {
        player = GetComponent<CharacterController>();
        rig = GetComponent<Rigidbody>();
        playerT = transform;

	}
	void playerMove()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

       
        playerT.rotation = Quaternion.Euler(0, mouseX, 0);
        player.Move(movement * Time.deltaTime);
   
    }

    void cameraRotate()
  {
      if (Input.GetMouseButton(1))
        {
            mouseX += Input.GetAxis("Mouse X");
            mouseY -= Input.GetAxis("Mouse Y");
        }

        mouseY = Mathf.Clamp(mouseY, -60f, 60f);
        transform.Rotate(0, mouseX, 0);
        movement = transform.rotation * movement;

    }
    // Update is called once per frame
    void Update () {
        playerMove();
        cameraRotate();

    }
}
