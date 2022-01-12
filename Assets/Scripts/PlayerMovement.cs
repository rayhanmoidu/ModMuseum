using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float y = 0f;

        if (Input.GetKey("space")) {
            y -= 10f;
        }

        if (Input.GetKey("q")) {
            y += 10f;
        }

        Vector3 move = transform.right * x + transform.forward * z + transform.up * y;

        controller.Move(move * speed * Time.deltaTime);
    }
}
