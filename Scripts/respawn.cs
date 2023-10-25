using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 spawnLocation;
    private CharacterController characterController;

    private void Start()
    {
        spawnLocation = transform.position;
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Check the player's Y position
        if (transform.position.y <= -10)
        {
            // Respawn the player at the spawn location
            Respawn();
        }
    }

    private void Respawn()
    {
        // Move the player to the spawn location using the Character Controller
        characterController.enabled = false;
        transform.position = spawnLocation;
        characterController.enabled = true;
    }
}
