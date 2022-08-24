using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindZoneController : MonoBehaviour
{
    public GameObject WindOn;

    // Start is called before the first frame update
    void Start()
    {
        WindOn.SetActive(true);
    }
}
