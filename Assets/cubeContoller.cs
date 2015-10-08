using UnityEngine;
using System.Collections;

public class cubeContoller : MonoBehaviour {

	void Update () 
    {
        transform.Translate(10 * Time.deltaTime, 0, 0);
	}
}
