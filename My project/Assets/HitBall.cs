using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponenet<RigidBody>();

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float f = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(2 * h, 0, 2 * f);
        rigidBody.AddForce(force);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
