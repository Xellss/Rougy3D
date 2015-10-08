using UnityEngine;
using System.Collections;

public class LightMovement : MonoBehaviour {

    public float RotatingSpeed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Rotate(RotatingSpeed * Time.deltaTime, 0, 0);
	}
}
