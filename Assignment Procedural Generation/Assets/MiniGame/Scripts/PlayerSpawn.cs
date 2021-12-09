using System.Collections;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    //serializes script components, creating variables for the player and the respawn point so game objects can be used.
    //
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    


    //method that uses OnTriggerEnter so that when the marblePlayer collides with the trigger it respawns at the respawn point.
    //
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
        
    }

    
}
