using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    //create Rb
    public Rigidbody agentRigidbody;
    //create speed variable
    public float agentSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        //Fetching the Rigidbody from the Gameobject with the script attached
        agentRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        int thrust = 10;
        //apply force
        agentRigidbody.AddForce(0,0, -thrust * agentSpeed);
    }
}
