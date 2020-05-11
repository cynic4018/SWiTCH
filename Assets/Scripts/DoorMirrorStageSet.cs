using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMirrorStageSet : MonoBehaviour
{
    public GameObject endCanvas;
    public CharacterSet character;
    public MirrorCharacterSet mirrorCharacter;
    public GameObject blurpanel;
    public SoundManager sm;
    private float counter = 0f;
    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject == character.gameObject){
            print("Clear1");
            PlayerPrefs.SetInt("MirrorWin", 1);
            PlayerPrefs.Save();
        }
        if(collision.gameObject == mirrorCharacter.gameObject){
            print("Clear2");
            PlayerPrefs.SetInt("MirrorWin", 2);
            PlayerPrefs.Save();
        }
    }

    void FixedUpdate() {
        if(PlayerPrefs.GetInt("MirrorWin") == 2){
            print("Congratulation");
            character.freeze = true;
            mirrorCharacter.freeze = true;
            sm.PassStageActive();
            counter += Time.deltaTime;
            if(counter >= 2.5){
                sm.StopPassStageActive();
            }
            blurpanel.GetComponent<ScaleBlur>().scalingUpBlur();
            endCanvas.SetActive(true);
        }    
    }
}
