using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterSet : MonoBehaviour
{
    // public NavMeshAgent agent;
    public bool freeze = false;
    public float speed = 2.5f;
    // private bool cooldownButton = false;
    // private float delayTime = 0.25f;
    public SoundManager sm;
    Rigidbody rb;
    void Awake(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * 15f, ForceMode.Acceleration);

        if(freeze == false){

            /*Old movement system*/
            // if(cooldownButton == false){
            //     if(Input.GetKeyDown(KeyCode.UpArrow)){
            //         this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.transform.position.y, this.transform.position.z+speed);
            //         Invoke("ResetCooldownButton", delayTime);
            //         cooldownButton = true;          
            //     }
            //     if(Input.GetKeyDown(KeyCode.DownArrow)){
            //         this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.transform.position.y, this.transform.position.z-speed);
            //         Invoke("ResetCooldownButton", delayTime);
            //         cooldownButton = true;                 
            //     }
            //     if(Input.GetKeyDown(KeyCode.LeftArrow)){
            //         this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x-speed, this.transform.position.y, this.transform.position.z);
            //         Invoke("ResetCooldownButton", delayTime);
            //         cooldownButton = true;                 
            //     }
            //     if(Input.GetKeyDown(KeyCode.RightArrow)){
            //         this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x+speed, this.transform.position.y, this.transform.position.z);
            //         Invoke("ResetCooldownButton", delayTime);
            //         cooldownButton = true;    
            //     }
            // }

            
            float translation = Input.GetAxis("Vertical") * speed;
            float rotation = Input.GetAxis("Horizontal") * speed;

            transform.Translate(0, 0, -translation);
            transform.Rotate(0, rotation, 0);

            if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)){
                sm.MoveSoundActive();
            }
            // else if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)){
            //     sm.MoveSoundOnetime();
            // }
            // else if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)){
            //     sm.StopMoveSoundActive();
            // }
        }
    }

    // void ResetCooldownButton(){
    //     cooldownButton = false;
    //     // print("already reset");
    // }
}

