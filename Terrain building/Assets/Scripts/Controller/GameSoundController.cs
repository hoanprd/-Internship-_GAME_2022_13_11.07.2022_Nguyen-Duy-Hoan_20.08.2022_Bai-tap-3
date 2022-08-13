using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSoundController : MonoBehaviour
{
    public AudioSource BGM;
    public AudioSource[] FX;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume1"))
        {
            PlayerPrefs.SetFloat("musicVolume1", 1);
            Load1();
        }
        else
        {
            Load1();
        }
        if (!PlayerPrefs.HasKey("musicVolume2"))
        {
            PlayerPrefs.SetFloat("musicVolume2", 1);
            Load2();
        }
        else
        {
            Load2();
        }
    }

    private void Load1()
    {
        BGM.volume = PlayerPrefs.GetFloat("musicVolume1");
    }
    private void Load2()
    {
        for (int i = 0; i < FX.Length; i++)
        {
            FX[i].volume = PlayerPrefs.GetFloat("musicVolume2");
        }
    }
}
