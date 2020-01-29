using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Slider musicVolume;
    public AudioSource volume;

    void Update()
    {
        volume.volume = musicVolume.value;
    }
}
