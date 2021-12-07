using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    //GameObject variable to put player object in.
    //
    public GameObject Player;
    
    //variable for distance
    //
    public float Distance;

    //boolean varibale for isAngered so the agent knows when to follow and not follow the player.
    //
    public bool isAngered;

    public NavMeshAgent agent;


    // Update is called once per frame
    void Update()
    {
        
        //calcualting distance between the two vector3s which is the player and the agent(enemy) - this.transform
        //
        Distance = Vector3.Distance(Player.transform.position, this.transform.position);


        //if statement to set what distance the enemy follows the player
        //
        if(Distance <= 10)
        {
            isAngered = true;
        }
        //tells enemy when to give up
        //
        if(Distance > 10f)
        {
            isAngered = false;
        }
        //if isangerd to false. starts to follow player if its close.
        //
        if (isAngered)
        {

            agent.isStopped = false;
            agent.SetDestination(Player.transform.position);
        }
        //if its not angered set isstopped top true which stops the enemy if you get too far away.
        //
        if (!isAngered)
        {
            agent.isStopped = true;
        }
    }
}
