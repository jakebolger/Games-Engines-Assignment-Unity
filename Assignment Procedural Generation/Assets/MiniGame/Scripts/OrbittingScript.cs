using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbittingScript : MonoBehaviour
{
    //varibles for distance we want to move on the x and z axis
    //
    public float xDistance;
    public float zDistance;

    //gives a way to have the camera above or below our centerpoint.
    //
    public float yOffset;
    
    //centerpoint reference varible.
    //
    public Transform centerPoint;

    //speed and direction variables when rotating.
    //
    public float rotationSpeed;
    public bool rotateDirection;

    //timer to update our position. always incrementing.
    //
    float timer = 0;



    // Update method that updates the movement.
    //
    void Update()
    {
        //increment the timer.
        //
        timer += Time.deltaTime * rotationSpeed;
        
        //calling the Rotate().
        //
        Rotate();
        
        //make transform of the camera look ast the centerpoint.
        //
        transform.LookAt(centerPoint);
    }

    void Rotate()
    {
        //check if we want to rotate clockwise or counter clockwise.
        //
        if (rotateDirection)
        {
            //getting new float that is the equivalent of -COs * time. allows it to repeat infinitely.
            //
            float x = -Mathf.Cos(timer) * xDistance;
            float z = Mathf.Sin(timer) * zDistance;

            //creates vector3 for posiiton.
            //
            Vector3 pos = new Vector3(x, yOffset, z);

            //
            transform.position = pos + centerPoint.position;
        }
        else
        {
            float x = Mathf.Cos(timer) * xDistance;
            float z = Mathf.Sin(timer) * zDistance;

            Vector3 pos = new Vector3(x, yOffset, z);

            transform.position = pos + centerPoint.position;
        }
    }

}
