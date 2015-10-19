using UnityEngine;
using System.Collections;

public class CameraRotate : MonoBehaviour {

	void Update () 
    {
        float MouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(MouseY, 0, 0);
	}
}
