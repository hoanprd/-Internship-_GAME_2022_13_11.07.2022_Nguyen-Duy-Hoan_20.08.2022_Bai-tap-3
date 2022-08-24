using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherController : MonoBehaviour
{
    public GameObject Rain;
    public GameObject Snow;
    public int state;

    // Start is called before the first frame update
    void Start()
    {
        state = Random.Range(0, 10);
        if (state == 0 || state == 1)
        {
            Rain.SetActive(true);
        }
        else if (state == 2 || state == 3)
        {
            Snow.SetActive(true);
        }
    }
}
