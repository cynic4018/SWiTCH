using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCheck : MonoBehaviour
{
    public GameObject tryAgainCanvas;
    public GameObject character;
    public CharacterSet characterSet;
    public SoundManager sm;
    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject == character){
            print("Falling");
            characterSet.freeze = true;
            sm.DieSoundActive();
            tryAgainCanvas.gameObject.SetActive(true);
        }
    }
}
