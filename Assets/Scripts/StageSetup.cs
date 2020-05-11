using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSetup : MonoBehaviour
{
    public List<GameObject> ItemStage = new List<GameObject>();
    public GameplayManager gm;
    // Start is called before the first frame update
    private int swapCount = 1;
    private int maxSwap = 3;
    private bool keepSwitchState;
    private int switchCount = 0;

    void Start()
    {
        keepSwitchState = gm.switchState;
        PlayerPrefs.SetInt("switchMirror", 0);
        PlayerPrefs.SetInt("PressM", 0);
        PlayerPrefs.SetInt("FourYou", 0);
        PlayerPrefs.SetInt("CUn", 0);
        PlayerPrefs.SetInt("MUn", 0);
        PlayerPrefs.SetInt("MirrorWin", 0);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(PlayerPrefs.HasKey("currentStage")){

            if(PlayerPrefs.GetInt("currentStage") == 1){
                if(gm.switchState){
                    ItemStage[0].SetActive(true);
                }else if(!gm.switchState){
                    ItemStage[0].SetActive(false);
                }
            }
            if(PlayerPrefs.GetInt("currentStage") == 2){
                
                if(gm.switchState != keepSwitchState){
                    keepSwitchState = gm.switchState;
                    if(swapCount >= maxSwap){
                        // print("Com3");
                        swapCount = 1;
                    }else{
                        swapCount++;
                    }

                    for(int i=0; i<maxSwap; i++){
                        if(i != swapCount-1){
                            ItemStage[i].SetActive(false);
                        }
                    }
                    ItemStage[swapCount-1].SetActive(true);
                }
            }
            if(PlayerPrefs.GetInt("currentStage") == 3){

                if(gm.switchState != keepSwitchState){
                    keepSwitchState = gm.switchState;
                    switchCount++;
                }
                if(switchCount == 1){
                    for(int i=0; i<ItemStage.Count; i++){
                        if(i%7 == 0 && i != 0){
                            ItemStage[i].SetActive(false);
                        }
                    }
                }
                if(switchCount == 2){
                    for(int i=0; i<ItemStage.Count; i++){
                        if(i%5 == 0 && i != 0){
                            ItemStage[i].SetActive(false);
                        }
                        else if(i%3 == 0 && i != 0){
                            ItemStage[i].SetActive(false);
                        }
                    }
                }
                if(switchCount == 3){
                    for(int i=0; i<ItemStage.Count; i++){
                        if(i != 0){
                            ItemStage[i].SetActive(false);
                        }
                    }
                }
                if(switchCount == 4){
                    for(int i=0; i<ItemStage.Count; i++){
                        ItemStage[i].SetActive(false);
                    }
                }
            }
            if(PlayerPrefs.GetInt("currentStage") == 4){
                
                if(gm.switchState != keepSwitchState){
                    keepSwitchState = gm.switchState;
                    switchCount++;
                    print(switchCount);
                }

                if(switchCount >= 4 && PlayerPrefs.GetInt("FourYou") == 1){
                    ItemStage[3].gameObject.SetActive(true);

                    PlayerPrefs.SetInt("FourYou", 0);
                    PlayerPrefs.Save();
                }
                if(switchCount == 2){
                    ItemStage[1].gameObject.SetActive(true);
                }
            }
            if(PlayerPrefs.GetInt("currentStage") == 5){
                
                if(gm.switchState != keepSwitchState){
                    keepSwitchState = gm.switchState;
                    switchCount++;
                    print(switchCount);
                }
                if(switchCount == 1){
                    PlayerPrefs.SetInt("switchMirror", 1);
                    PlayerPrefs.Save();

                    if(PlayerPrefs.GetInt("MUn") == 1 && PlayerPrefs.GetInt("CUn") == 1){
                        // print("Ki");
                        PlayerPrefs.SetInt("PressM", 1);
                        PlayerPrefs.Save();
                    }
                } 
                if(switchCount == 8 && PlayerPrefs.GetInt("PressM") == 1){
                    PlayerPrefs.SetInt("switchMirror", 2);
                    PlayerPrefs.SetInt("PressM", 2);
                    PlayerPrefs.Save();
                }
                if(switchCount == 11 && PlayerPrefs.GetInt("PressM") == 2){
                    PlayerPrefs.SetInt("switchMirror", 3);
                    PlayerPrefs.Save();
                    // print("Accept");
                }
            }

        }
    }

    public void FourHiddenSetting(){
        PlayerPrefs.SetInt("FourYou", 1);
        PlayerPrefs.Save();

        print("4");
    }
}

