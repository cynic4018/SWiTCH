using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleDownMirror : MonoBehaviour
{
    Animator animator;

    public GameObject outPortal;
    public SoundManager sm;

    void Start() {
        animator = GetComponent<Animator>();    
    }
    void FixedUpdate()
    {
        if( PlayerPrefs.GetInt("switchMirror") == 3 && PlayerPrefs.GetInt("PressM") == 2){
            animator.SetBool("Down", true);
        } 
    }

    void OnCollisionEnter(Collision other) {
        other.gameObject.transform.position = new Vector3(outPortal.transform.position.x, outPortal.transform.position.y + 30, outPortal.transform.position.z);
        other.gameObject.transform.rotation = outPortal.transform.rotation;
        sm.MoveSoundActive();
    }
}
