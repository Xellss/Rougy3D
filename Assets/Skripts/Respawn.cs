using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (transform.position.y < -20)
        {
            transform.position = new Vector3(0, 0, 0);
        }

	}
}
