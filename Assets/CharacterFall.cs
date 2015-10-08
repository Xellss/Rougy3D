using UnityEngine;
using System.Collections;

public class CharacterFall : MonoBehaviour {

	void Update () {
        if (transform.position.y < -20 )
            transform.position = new Vector3(0, 0, 0);
	}
}
