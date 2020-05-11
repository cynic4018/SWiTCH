using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageFourCamera : MonoBehaviour
{
    public GameObject mainCamera;
    void Start()
    {
        mainCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<1001; i++){
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z+i);
        }
        mainCamera.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
