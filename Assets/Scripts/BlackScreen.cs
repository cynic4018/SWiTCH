using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackScreen : MonoBehaviour
{
    public Image panel;
    public GameObject canvas;
    float startingTime = 1.25f;
    private bool stateFade = false;

    // public void blackFade(CanvasGroup panelFade){
    //     if(panelFade <= 0){
    //         canvas.SetActive(!canvas.activeSelf);
    //     }   
    // }

    // void Awake() {
        
    // }

    public IEnumerator blackFade(CanvasGroup panelFade, float start, float end){
        float counter = 0f;

        while(counter < startingTime){
            counter += Time.deltaTime;
            panelFade.alpha = Mathf.Lerp(start, end, counter / startingTime);
            
            yield return null;
        }
        stateFade = true;
    }

    void Update() {
        CanvasGroup panelFade = panel.GetComponent<CanvasGroup>();

        StartCoroutine(blackFade(panelFade, panelFade.alpha, stateFade ? 1 : 0)); 

        if(stateFade == true){
            canvas.SetActive(!canvas.activeSelf);
            // print("Already faded!!");
        }
    }
}
