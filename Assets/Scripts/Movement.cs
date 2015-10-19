using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float JumpPower = 1;

    bool jump = false;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Cube")
        {
            
        }
    }

    void Update()
    {
        float x = Input.GetAxis("Vertical");
        float MouseX = Input.GetAxis("Mouse X");

        transform.Translate(x, 0, 0);
        transform.Rotate(0, MouseX, 0);

        //if (Input.GetButtonDown("Jump") & !jump)
        //{
        //    transform.Translate(0, JumpPower, 0);
        //}
    }
}
