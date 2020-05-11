using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectStageManager : MonoBehaviour
{
    public List<GameObject> stage_list = new List<GameObject>();
    void Start()
    {
        if(PlayerPrefs.GetInt("maxStage") == 0){
            PlayerPrefs.SetInt("maxStage", 1);
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<PlayerPrefs.GetInt("maxStage"); i++){
            stage_list[i].SetActive(true);
        }
    }
}
