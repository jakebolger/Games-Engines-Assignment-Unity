using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleMove : MonoBehaviour
{
    //variable for movement speed.
    //
    public float speed = 5.0f;
    
    //varibale for horizontal input.
    //
    private float horizontalInput;
    
    //variable for forward input.
    //
    private float forwardInput;

    

    // Update is called once per frame
    void Update()
    {
        //sets Horizontalinput from project settings to  "Horizontal".
        //
        horizontalInput = Input.GetAxis("Horizontal");
        //sets forwardinput from project settings to  "Vertical".
        //
        forwardInput = Input.GetAxis("Vertical");

        //uses two vector3s to allow movement using the variables.
        //
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
}
