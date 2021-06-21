using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileLauncher : MonoBehaviour
{
    Rigidbody Rigidbody;
    public float power = 20;
    bool hasStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(Input.GetButton("Jump") && hasStarted == false)
        {
            Rigidbody.AddForce(0, power, 0, ForceMode.Impulse);
            hasStarted = true;
        }
    }
}
