using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFreezeCharacter : MonoBehaviour
{
    public CharacterSet character;
    // Update is called once per frame

    void OnEnable() {
        // print("O");
        character.freeze = true;
    }

    void OnDisable() {
        // print("X");
        character.freeze = false;
    }
}
