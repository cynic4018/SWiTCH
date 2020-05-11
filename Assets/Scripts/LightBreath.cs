using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBreath : MonoBehaviour
{
    private float calcFactor = -1;
    void FixedUpdate()
    {
        Light light = this.GetComponent<Light>();

        light.intensity += calcFactor;
        if(light.intensity == 0 && calcFactor == -1){
            calcFactor = 1;
        }else if(light.intensity == 100 && calcFactor == 1){
            calcFactor = -1;
        }
    }
}
