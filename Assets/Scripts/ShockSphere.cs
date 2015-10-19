using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem))]
public class ShockSphere : MonoBehaviour {

    ParticleSystem shockSphere;

    void Awake()
    {
        shockSphere = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Input.GetButtonDown("ShockSphere"))
        {
            shockSphere.Play();
        }
    }
}
