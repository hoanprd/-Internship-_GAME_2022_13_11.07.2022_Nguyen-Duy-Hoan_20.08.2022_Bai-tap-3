using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityCoreForce : MonoBehaviour
{
    public float Gravity = -12;

    public void Attract(Transform PlayerTransform)
    {
        Vector3 gravityUp = (PlayerTransform.position - transform.position).normalized;
        Vector3 localUp = PlayerTransform.up;

        PlayerTransform.GetComponent<Rigidbody>().AddForce(gravityUp * Gravity);

        Quaternion targetRotation = Quaternion.FromToRotation(localUp, gravityUp) * PlayerTransform.rotation;
        PlayerTransform.rotation = Quaternion.Slerp(PlayerTransform.rotation, targetRotation, 50f * Time.deltaTime);
    }
}