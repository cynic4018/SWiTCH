using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlatform : MonoBehaviour
{
    public GameObject character;
    public string axis;
    void OnTriggerStay(Collider other) {
        if(axis == "z"){
            if(Input.GetKeyDown(KeyCode.UpArrow) == true){
                other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z+45);
            }
            else if(Input.GetKeyDown(KeyCode.DownArrow) == true){
                other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z-45); 
            }
            else if(other.gameObject == character){
                print("L");
                other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, this.transform.position.z);
            }
        }
        if(axis == "y"){
            // if(Input.GetKeyDown(KeyCode.UpArrow) == true){
            //     other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z+25); 
            // }
            // else if(Input.GetKeyDown(KeyCode.DownArrow) == true){
            //     other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z-25); 
            // }
            if(other.gameObject == character){
                other.transform.position = new Vector3(other.transform.position.x, this.transform.position.y, other.transform.position.z);
            }
        }
        if(axis == "x"){
            if(Input.GetKeyDown(KeyCode.UpArrow) == true){
                other.transform.position = new Vector3(other.transform.position.x-45, other.transform.position.y, other.transform.position.z);
            }
            else if(Input.GetKeyDown(KeyCode.DownArrow) == true){
                other.transform.position = new Vector3(other.transform.position.x+45, other.transform.position.y, other.transform.position.z); 
            }
            else if(other.gameObject == character){
                print("L");
                other.transform.position = new Vector3(this.transform.position.x, other.transform.position.y, other.transform.position.z);
            }
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.gameObject == character){
            character.transform.parent = null;
        }
    }
}
