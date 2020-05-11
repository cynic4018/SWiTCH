using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSet : MonoBehaviour
{
    public GameObject target;
    public GameplayManager gm;

    public Color switchOffBGColor;
    public Color switchOnBGColor;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(target.transform.position.x + this.gameObject.transform.position.x,
                                                        this.gameObject.transform.position.y, 
                                                        target.transform.position.z + this.gameObject.transform.position.z);
    }

    void Update(){
        if(gm.switchState == true){
            this.GetComponent<Camera>().backgroundColor = switchOnBGColor;
        }
        else if(gm.switchState == false){
            this.GetComponent<Camera>().backgroundColor = switchOffBGColor;
        }
    }
}
