using UnityEngine;
using System.Collections;

public class FallDown : MonoBehaviour
{
    public float CurrentYPosition = 60;
    public float FallDownSpeed = 1;
    private bool PlatformMoveTop = false;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
            PlatformMoveTop = false;
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player") 
            transform.Translate(0, -FallDownSpeed * Time.deltaTime, 0);
    }

    // If Char had collision in the last 3 sec with the "Elevator", keep moving down (Yield?).

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlatformMoveTop = true;
            print("Collison exit");
        }
        //while (transform.position.y < CurrentYPosition)
        //{
            //transform.Translate(0, FallDownSpeed * Time.deltaTime, 0);
        //}
    }

    void update()
    {
        if (transform.position.y < CurrentYPosition && PlatformMoveTop)
            transform.Translate(0, FallDownSpeed * Time.deltaTime, 0);
    }
}