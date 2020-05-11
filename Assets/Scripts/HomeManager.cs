using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeManager : MonoBehaviour
{
    public Button playButton;
    // Start is called before the first frame update
    private Color newColor;
    public ScenesController scenesController;
    public GameObject exitBlurPanel;
    public GameObject canvasForESC;

    void Start()
    {
        scenesController = FindObjectOfType<ScenesController>();
        newColor = new Color(0f, 0f, 0f);
    }

    public void delayShow(){
        scenesController.LoadScene("SelectStage");
    }

    public void changeColor(){
        playButton.image.color = newColor;
        Invoke("delayShow", 0.65f);
    }

    public void exitGame(){
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && canvasForESC.activeSelf == false){
            exitBlurPanel.GetComponent<ScaleBlur>().scalingUpBlur();
            canvasForESC.SetActive(!canvasForESC.activeSelf);
            // print("In: "+canvasForESC.activeSelf);
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && canvasForESC.activeSelf == true){ 
            exitBlurPanel.GetComponent<ScaleBlur>().scalingDownBlur();
            // print("Out: "+canvasForESC.activeSelf);
        }
        
    }
}
