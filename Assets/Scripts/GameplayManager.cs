using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    //State of switch: true = switch-on, false = switch-off
    public bool switchState = false;
    public Button switchButton;
    public Sprite OnSwitch;
    public Sprite OffSwitch;


    public void changeSwitchState(){
        switchState = !switchState;
        if(switchState){
            switchButton.GetComponent<Image>().sprite = OnSwitch;
        }
        else if(!switchState){
            switchButton.GetComponent<Image>().sprite = OffSwitch;
        }
        // print("Now switch state: "+ switchState);
    }

    // Update is called once per frame
    void Update()
    {

        // print(PlayerPrefs.GetInt("currentStage"));
    }
}
