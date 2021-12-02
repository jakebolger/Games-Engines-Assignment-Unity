
using UnityEngine;

public class PlaneAgents : MonoBehaviour
{
    //create Rb
    public Rigidbody agentRigidbody;
    //create speed variable
    public float agentSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //Fetching the Rigidbody from the Gameobject with the script attached
        agentRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //apply force
        agentRigidbody.AddForce(transform.up * agentSpeed);
    }
}
