using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeNumOfStage : MonoBehaviour
{
    public void changeNumStage(int number){
        PlayerPrefs.SetInt("currentStage", number);
        PlayerPrefs.Save();
    }

    public void maxReachStage(){
        if(PlayerPrefs.GetInt("currentStage") >= PlayerPrefs.GetInt("maxStage")){
            PlayerPrefs.SetInt("maxStage", PlayerPrefs.GetInt("currentStage"));
            PlayerPrefs.Save();
        }
    }
}
