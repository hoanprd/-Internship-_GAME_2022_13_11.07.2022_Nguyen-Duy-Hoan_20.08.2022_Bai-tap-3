using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherController : MonoBehaviour
{
    public GameObject Rain;
    public GameObject Snow;
    public GameObject LakeOff;
    public GameObject[] FreezeWater;
    public GameObject DewRainWater;
    public int state;
    public bool IsRain;
    public bool IsSnow;
    public float StopTimer;
    //public bool RainDebug;
    //public bool SnowDebug;

    // Start is called before the first frame update
    void Start()
    {
        Shader.SetGlobalFloat("_SnowLevel", 0f);
        state = Random.Range(0, 10);
        if (state == 0 || state == 1)
        {
            Rain.SetActive(true);
            //StopTimer = 60;
            IsRain = true;
            Shader.SetGlobalFloat("_SnowLevel", 0f);
        }
        else if (state == 2 || state == 3)
        {
            Snow.SetActive(true);
            IsSnow = true;
            for (int i = 0; i < FreezeWater.Length; i++)
            {
                if (i == 0)
                {
                    LakeOff.SetActive(false);
                    FreezeWater[i].GetComponent<TerrainCollider>().enabled = true;
                }
                else
                    FreezeWater[i].GetComponent<MeshCollider>().enabled = true;
            }
        }
    }

    void Update()
    {
        if (IsRain && StopTimer > 0)
        {
            StopTimer -= Time.deltaTime;
        }

        if (IsRain && StopTimer <= 0)
        {
            DewRainWater.SetActive(true);
            IsRain = false;
            Rain.SetActive(false);
        }
    }
}
