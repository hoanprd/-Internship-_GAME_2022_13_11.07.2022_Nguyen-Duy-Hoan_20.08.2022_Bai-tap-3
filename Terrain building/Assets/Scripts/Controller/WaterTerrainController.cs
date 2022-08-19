using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTerrainController : MonoBehaviour
{
    public Behaviour WaterTerrainScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            WaterTerrainScript.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        WaterTerrainScript.enabled = false;
    }
}
