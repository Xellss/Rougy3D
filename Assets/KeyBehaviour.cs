using UnityEngine;
using System.Collections;

public class KeyBehaviour : MonoBehaviour
{

    void OnCollsionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
