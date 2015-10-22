using UnityEngine;
using System.Collections;

public class CameraRotate : MonoBehaviour
{
    public Transform LookAtObject;

    [Range(0.1f, 5f)]
    public float LookAtSpeed = 0.8f;

    void LootAt()
    {
        if (LookAtObject == null)
            return;

        transform.forward = LookAtObject.forward;
        transform.LookAt(LookAtObject);
    }
    void LateUpdate()
    {
        //transform.Translate(0, 0, 0);

        float MouseY = Input.GetAxis("Mouse Y");
        transform.Translate(0, MouseY, 0);

        if (Input.GetButton("LookRight"))
            transform.Rotate(0, LookAtSpeed, 0, Space.Self);

        if (Input.GetButton("LookLeft"))
            transform.Rotate(0, -LookAtSpeed, 0, Space.Self);

        if (Input.GetButton("LookUp"))
            transform.Translate(0, LookAtSpeed, 0, Space.Self);

        if (Input.GetButton("LookDown"))
            transform.Translate(0, -LookAtSpeed, 0, Space.Self);

        LootAt();
    }

    //void LateUpdate()
    //{
    //    LootAt();
    //}
}
