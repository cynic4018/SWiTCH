using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActive : MonoBehaviour
{
    public GameObject item;

    public void setActiveItem(){
        if(item != null){
            bool isActive = item.activeSelf;

            item.SetActive(!isActive);
        }
    }
}
