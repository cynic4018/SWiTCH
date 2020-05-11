using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallMirrorCheck : MonoBehaviour
{
    public GameObject tryAgainCanvas;
    public GameObject characterMirror;
    public MirrorCharacterSet mirrorCharacterSet;
    public SoundManager sm;
    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject == characterMirror){
            print("Falling");
            sm.DieSoundActive();
            mirrorCharacterSet.freeze = true;
            tryAgainCanvas.gameObject.SetActive(true);
        }
    }
}
