using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem))]
public class ShockCone : MonoBehaviour
{
    ParticleSystem shockCone;

    void Awake()
    {
        shockCone = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Input.GetButtonDown("ShockCone"))
            shockCone.Play();
    }
}
