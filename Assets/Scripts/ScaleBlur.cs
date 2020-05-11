using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBlur : MonoBehaviour
{
    public Material blurMat;
    public float maxBlur;
    public float minBlur;
    private float currentBlur;
    private bool firstCheck = false;

    public GameObject item;

    public void scalingUpBlur(){
        if(firstCheck == false){
            currentBlur = minBlur;
            firstCheck = true;
            Invoke("scalingUpBlur", 0.02f);
        }
        else if(currentBlur < maxBlur){
            blurMat.SetFloat("_BlurSize", currentBlur+(maxBlur/8));
            currentBlur = currentBlur + (maxBlur/8);
            Invoke("scalingUpBlur", 0.02f);
        }else{
            firstCheck = false;
            // print("UP ok");
        }
    }

    public void scalingDownBlur(){
        if(firstCheck == false){
            currentBlur = maxBlur;
            firstCheck = true;
            Invoke("scalingDownBlur", 0.02f);
        }
        else if(currentBlur > minBlur){
            blurMat.SetFloat("_BlurSize", currentBlur-(maxBlur/8));
            currentBlur = currentBlur - (maxBlur/8);
            Invoke("scalingDownBlur", 0.02f);
        }
        else{
            item.SetActive(!item.activeSelf);
            firstCheck = false;
            // print("Down ok");
        }
    }
}
