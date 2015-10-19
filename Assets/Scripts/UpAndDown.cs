using UnityEngine;
using System.Collections;

public class UpAndDown : MonoBehaviour
{
    public float MovementSpeed = 5;

    float topPosition = 7;
    float downPosition = 0;
    bool playerCollision = false;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Collision Enter");
            playerCollision = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(WaitForUpMovement(0.5f));
        }
    }

    void Update()
    {
        if (transform.position.y < topPosition && playerCollision)
        transform.Translate(0,MovementSpeed,0);

        if (transform.position.y > downPosition & !playerCollision)
            transform.Translate(0, -MovementSpeed, 0);
    }

    IEnumerator WaitForUpMovement(float time)
    {
        yield return new WaitForSeconds(time);
        playerCollision = false;
        print("Collision Exit");

    }

}
