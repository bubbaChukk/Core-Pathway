using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCheck : MonoBehaviour
{

    rotationStation rotation = null;
    // Start is called before the first frame update
    void Start()
    {
        rotation = GameObject.Find("whacker").GetComponent<rotationStation>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "Sphere")
        {
            rotation.startRotating = true;
        }
    }
}
