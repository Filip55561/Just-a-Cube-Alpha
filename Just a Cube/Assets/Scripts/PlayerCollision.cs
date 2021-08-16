using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

        // This Function runs when we hit another object.
        // We Get information about the collision and call it "collisionInfo"
    void OnCollisionEnter (Collision collisionInfo)
    {
        // We check if the object we collided with has tag called "Obstacle".
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}