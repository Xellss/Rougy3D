using UnityEngine;
using System.Collections;

public class ElevatorMovement : MonoBehaviour
{

    public float RotationSpeed = 1;
    public float MoveSpeed = 1;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);

        transform.Translate(0, MoveSpeed * Time.deltaTime, 0);

    }
}
