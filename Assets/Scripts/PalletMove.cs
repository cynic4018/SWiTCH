using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalletMove : MonoBehaviour
{
    public float moveMax;
    public float speed;
    public string axis;
    private float stackDistance = 0f;
    private string stateUpDown = "up";
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        if(axis == "z"){
            if(stackDistance < moveMax && stateUpDown == "up"){
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, 
                                                                this.gameObject.transform.position.y, 
                                                                this.gameObject.transform.position.z+speed);
                stackDistance += speed;

                if(stackDistance >= moveMax){
                    stateUpDown = "down";
                }
            }
            else if(stackDistance >= 0 && stateUpDown == "down"){
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, 
                                                                this.gameObject.transform.position.y, 
                                                                this.gameObject.transform.position.z-speed);
                stackDistance -= speed;

                if(stackDistance <= 0){
                    stateUpDown = "up";
                }
            }
        } 
        else if(axis == "y"){
            if(stackDistance < moveMax && stateUpDown == "up"){
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, 
                                                                this.gameObject.transform.position.y+speed, 
                                                                this.gameObject.transform.position.z);
                stackDistance += speed;

                if(stackDistance >= moveMax){
                    stateUpDown = "down";
                }
            }
            else if(stackDistance >= 0 && stateUpDown == "down"){
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, 
                                                                this.gameObject.transform.position.y-speed, 
                                                                this.gameObject.transform.position.z);
                stackDistance -= speed;

                if(stackDistance <= 0){
                    stateUpDown = "up";
                }
            }
        }
        else if(axis == "x"){
            if(stackDistance < moveMax && stateUpDown == "up"){
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x+speed, 
                                                                this.gameObject.transform.position.y, 
                                                                this.gameObject.transform.position.z);
                stackDistance += speed;

                if(stackDistance >= moveMax){
                    stateUpDown = "down";
                }
            }
            else if(stackDistance >= 0 && stateUpDown == "down"){
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x-speed, 
                                                                this.gameObject.transform.position.y, 
                                                                this.gameObject.transform.position.z);
                stackDistance -= speed;

                if(stackDistance <= 0){
                    stateUpDown = "up";
                }
            }
        }  
    }
}
