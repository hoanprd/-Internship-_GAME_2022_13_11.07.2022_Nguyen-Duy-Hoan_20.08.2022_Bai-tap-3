using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowCover : MonoBehaviour
{
    [Range(0.01f, 0.1f)]
    public float SnowCoverSpeed;
    float value = 0;
    // Start is called before the first frame update
    void Start()
    {
        Shader.SetGlobalFloat("_SnowLevel", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (value < 1f)
        {
            Shader.SetGlobalFloat("_SnowLevel", value);
            value += Time.deltaTime * SnowCoverSpeed;
        }
    }
}
