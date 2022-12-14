using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundMute : MonoBehaviour
{
    public Sprite muteOn;
    public Sprite muteOff;
    public Image buttonMute;
    private void Start()
    {
        if (Audio.instancia.gameObject.GetComponent<AudioSource>().mute == true)
        {
            buttonMute.sprite = muteOn;
        }
        else
        {
            buttonMute.sprite = muteOff;
        }
    }
    public void AudioMute()
    {
        if (Audio.instancia.gameObject.GetComponent<AudioSource>().mute == true)
        {
            Audio.instancia.gameObject.GetComponent<AudioSource>().mute = false;
            buttonMute.sprite= muteOff;
        }
        else
        {
            Audio.instancia.gameObject.GetComponent<AudioSource>().mute = true;
            buttonMute.sprite = muteOn;
        }
        
    }
}
