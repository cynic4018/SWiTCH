using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlateMirror : MonoBehaviour
{
    Animator animator;
    void Start() {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("switchMirror") == 1){
            animator.SetBool("CheckOn", true);
        }
        if(PlayerPrefs.GetInt("switchMirror") == 2){
            animator.SetBool("CheckOn", false);
        }
    }
}
