using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioSource backgroundSound;
    public AudioSource moveSound;
    public AudioSource dieSound;
    public AudioSource passStageSound;
    public AudioSource buttonSound;
    public AudioMixer mixer;

    // Start is called before the first frame update
    void Start()
    {
        mixer.SetFloat("Master", PlayerPrefs.GetFloat("Master"));
        mixer.SetFloat("BG", PlayerPrefs.GetFloat("BG"));
        mixer.SetFloat("SFX", PlayerPrefs.GetFloat("SFX"));
        backgroundSound.Play();
    }

    public void DieSoundActive()
    {
        dieSound.Play();
    }

    public void MoveSoundActive()
    {
        moveSound.Play();
    }

    public void StopMoveSoundActive(){
        moveSound.Stop();
    }
    public void PassStageActive()
    {
        passStageSound.Play();
    }

    public void StopPassStageActive(){
        passStageSound.Stop();
    }

    public void ButtonSoundActive()
    {
        buttonSound.Play();
    }

    public void StopBG(){
        backgroundSound.Stop();
    }
}
