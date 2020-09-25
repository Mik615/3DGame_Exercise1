using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Assigned to the character to open the door
public class OpenDoor : MonoBehaviour {
    private bool isTriggered = false;

    // When the player collides with the door
    private void OnTriggerEnter(Collider other) {
        // Only trigger once
        if (!isTriggered) {
            isTriggered = true;
            // Move door to open position (static)
            other.transform.Rotate(0, 90, 0);
            other.transform.position = new Vector3(-20, 3, -11);
        }
    }
}
