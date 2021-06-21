using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationStation : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 angleVelocity;
    public bool startRotating = false;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        angleVelocity = new Vector3(0, 0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (startRotating == true)
        {
            Quaternion deltaRotation = Quaternion.Euler(angleVelocity * Time.fixedDeltaTime);
            m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
        }
        
    }
}
