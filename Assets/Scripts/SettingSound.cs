using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingSound : MonoBehaviour
{
    public Slider master;
    public Slider BG;
    public Slider SFX;
    public AudioMixer mixer;
    public ScenesController sc;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("Master")){
            mixer.SetFloat("Master",  PlayerPrefs.GetFloat("Master"));
            master.value = PlayerPrefs.GetFloat("Master");   
        }
        if(PlayerPrefs.HasKey("BG")){
            mixer.SetFloat("BG", PlayerPrefs.GetFloat("BG"));
            BG.value = PlayerPrefs.GetFloat("BG"); 
        }
        if(PlayerPrefs.HasKey("SFX")){
            mixer.SetFloat("SFX", PlayerPrefs.GetFloat("SFX"));
            SFX.value = PlayerPrefs.GetFloat("SFX");      
        }
    }

    public void SaveSetting(){
        // print("Save sound");
        PlayerPrefs.SetFloat("Master", master.value);
        PlayerPrefs.SetFloat("BG",  BG.value);
        PlayerPrefs.SetFloat("SFX",  SFX.value);
        print("Setting Master:" + master.value);
        print("Setting BG:" + BG.value);
        print("Setting SFX:" + SFX.value);
        PlayerPrefs.Save();
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        mixer.SetFloat("Master",  master.value);
        mixer.SetFloat("BG",  BG.value);
        mixer.SetFloat("SFX",  SFX.value);
    }

}
