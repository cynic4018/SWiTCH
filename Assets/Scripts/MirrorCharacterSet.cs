using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MirrorCharacterSet : MonoBehaviour
{
    // public NavMeshAgent agent;
    public bool freeze = false;
    public float speed = 2.5f;
    // private bool cooldownButton = false;
    // private float delayTime = 0.20f;
    Rigidbody rb;
    void Awake(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * 15f, ForceMode.Acceleration);

        if(freeze == false){

            float translation = Input.GetAxis("Vertical") * speed;
            float rotation = Input.GetAxis("Horizontal") * speed;

            transform.Translate(0, 0, -translation);
            transform.Rotate(0, rotation, 0);
            
        }
    }

    // void ResetCooldownButton(){
    //     cooldownButton = false;
    //     // print("already reset");
    // }
}

