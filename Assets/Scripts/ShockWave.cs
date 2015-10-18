using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem))]
public class ShockWave : MonoBehaviour
{
    ParticleSystem shockWave;

    void Awake()
    {
        shockWave = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Input.GetButtonDown("ShockWave"))
        {
            shockWave.Play();
        }
    }
}
