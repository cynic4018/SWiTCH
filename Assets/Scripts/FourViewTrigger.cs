using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourViewTrigger : MonoBehaviour
{
    public GameObject character;
    public GameObject fourYouButton;
    void OnCollisionEnter(Collision other) {
        if(other.gameObject == character){
            fourYouButton.SetActive(true);
            print("True");
        }
    }
}
