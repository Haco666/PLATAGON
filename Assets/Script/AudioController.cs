using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public bool musicMute;
    public bool soundMute;
    public bool masterMute;
    public AudioMixer audioMixer;
    public float previousSound = 0;
    public float previousMusic = 0;
    public float previuosMaster = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioMixer = Resources.Load<AudioMixer>("MainMixed");
    }
    public float GetLevel(string bus)
    {
        float value;
        bool result = audioMixer.GetFloat(bus, out value);
        if (result)
        {
            return value;

        }
        else
        {
            return 0f;
        }
    }
    public void MasterVolume(Slider volume)
    {
        audioMixer.SetFloat("Master", volume.value);
    }
    public void SoundVolume(Slider volume)
    {
        audioMixer.SetFloat("Sonidos", volume.value);
    }
    public void MusicVolume(Slider volume)
    {
        audioMixer.SetFloat("Musica", volume.value);
    }

    public void SoundMute()
    {
        if (soundMute)
        {
            soundMute = false;
            audioMixer.SetFloat("Sonidos", previousSound);
        }
        else
        {
            soundMute = true;
            previousSound = GetLevel("Sonidos");
            audioMixer.SetFloat("Sonidos", -80);
        }
    }
    public void MusicMute()
    {
        if (musicMute)
        {
            musicMute = false;
            audioMixer.SetFloat("Musica", previousMusic);
        }
        else
        {
            musicMute = true;
            previousMusic = GetLevel("Musica");
            audioMixer.SetFloat("Musica", -80);
        }
    }
    public void MasterMute()
    {
        if (masterMute)
        {
            masterMute = false;
            audioMixer.SetFloat("Master", previuosMaster);
        }
        else
        {
            masterMute = true;
            previuosMaster = GetLevel("Master");
            audioMixer.SetFloat("Master", -80);
        }
    }
}