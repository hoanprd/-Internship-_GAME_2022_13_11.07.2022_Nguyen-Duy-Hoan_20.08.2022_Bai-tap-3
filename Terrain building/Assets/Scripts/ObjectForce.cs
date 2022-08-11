using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectForce : MonoBehaviour
{
    public GravityCoreForce AttractorPlanet;
    private Transform PlayerTransform;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        PlayerTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (AttractorPlanet)
        {
            AttractorPlanet.Attract(PlayerTransform);
        }
    }
}