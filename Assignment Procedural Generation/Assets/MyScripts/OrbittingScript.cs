using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbittingScript : MonoBehaviour
{
    public float xDistance;
    public float zDistance;

    public float yOffset;
    public Transform centerPoint;

    public float rotationSpeed;
    public bool rotateDirection;

    float timer = 0;



    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * rotationSpeed;
        Rotate();
        transform.LookAt(centerPoint);
    }

    void Rotate()
    {
        if (rotateDirection)
        {
            float x = -Mathf.Cos(timer) * xDistance;
            float z = Mathf.Sin(timer) * zDistance;

            Vector3 pos = new Vector3(x, yOffset, z);

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
