using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public GameObject Player;
    public float Distance;

    public bool isAngered;

    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Player.transform.position, this.transform.position);

        if(Distance <= 5)
        {
            isAngered = true;
        }
        if(Distance > 5f)
        {
            isAngered = false;
        }
        if (isAngered)
        {

            agent.isStopped = false;
            agent.SetDestination(Player.transform.position);
        }
        if (!isAngered)
        {
            agent.isStopped = true;
        }
    }
}
