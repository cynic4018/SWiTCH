using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSet : MonoBehaviour
{
    public GameObject endCanvas;
    public CharacterSet character;
    public GameObject blurpanel;
    public SoundManager sm;
    void OnCollisionEnter(Collision collision) {
        print("Congratulation");
        character.freeze = true;
        sm.PassStageActive();
        sm.StopBG();
        blurpanel.GetComponent<ScaleBlur>().scalingUpBlur();
        endCanvas.SetActive(true);
    }
}
