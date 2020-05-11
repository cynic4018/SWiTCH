using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    Animator animator;

    public CharacterSet character;
    private float countWalkTime = 0f;
    private float countTurnTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(character.freeze == false){
            /*Animations for character actions: Turn-Left, Turn-Right, walk and idle*/
            if(Input.GetKeyDown(KeyCode.UpArrow)){
                animator.SetBool("Walk", true);
                animator.SetBool("Left", false);
                animator.SetBool("Right", false);
            }
            if(Input.GetKeyDown(KeyCode.DownArrow)){
                animator.SetBool("Walk", true); 
                animator.SetBool("Left", false);
                animator.SetBool("Right", false);
            }
            /*Bring the animation back from walk to idle*/
            if(animator.GetBool("Walk") == true){
                countWalkTime += Time.deltaTime;

                if(countWalkTime >= 0.35f){
                    countWalkTime = 0f;
                    animator.SetBool("Walk", false);
                }
            }
            
            if(Input.GetKeyDown(KeyCode.LeftArrow)){
                animator.SetBool("Left", true);
                animator.SetBool("Right", false);
            }
            if(Input.GetKeyDown(KeyCode.RightArrow)){
                animator.SetBool("Left", false);
                animator.SetBool("Right", true);
            }

            if(animator.GetBool("Left") == true || animator.GetBool("Right") == true){
                countTurnTime += Time.deltaTime;

                if(countTurnTime >= 0.25f){
                    countTurnTime = 0f;
                    animator.SetBool("Left", false);
                    animator.SetBool("Right", false);
                }
            }
        }
    }
}
