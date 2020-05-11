using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTwoHideMirror : MonoBehaviour
{
    public GameObject character;
    public GameObject characterMirror;
    
    void OnCollisionEnter(Collision other) {
        if(other.gameObject == character){
            if(PlayerPrefs.GetInt("switchMirror") == 1){
                // print("CUn");
                PlayerPrefs.SetInt("CUn", 1);
                PlayerPrefs.Save();
            }
        }
        if(other.gameObject == characterMirror){
            if(PlayerPrefs.GetInt("switchMirror") == 1){
                // print("MUn");
                PlayerPrefs.SetInt("MUn", 1);
                PlayerPrefs.Save();
            }
        }
    }
}
