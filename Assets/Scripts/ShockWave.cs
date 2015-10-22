using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem))]
public class ShockWave : MonoBehaviour
{
    ParticleSystem shockWave;

    GameObject playerObject;
    Movement playerMovement;

    public float JumDuration;

    private bool Jump = false;
    private bool JumpCone = false;

    void Awake()
    {
        shockWave = GetComponent<ParticleSystem>();
        playerObject = GameObject.Find("Player");
        playerMovement = playerObject.GetComponent<Movement>();
    }

    void Update()
    {
        if (Input.GetButtonDown("ShockWave"))
            shockWave.Play();
        ConeJump();
    }

    void ConeJump()
    {
        if (!playerMovement.Grounded)
            StartCoroutine(JumpTime(JumDuration));

        if (playerMovement.Grounded && JumpCone)
        {
            shockWave.Play();
            JumpCone = false;
            //StopAllCoroutines();
        }
        if (playerMovement.Grounded && Jump && !JumpCone)
        {
            StopAllCoroutines();
            Jump = false;
        }

    }

    IEnumerator JumpTime(float time)
    {
        Jump = true;
        yield return new WaitForSeconds(time);
        JumpCone = true;

    }
}
