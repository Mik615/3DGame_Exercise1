using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Moves object between 2 given positions
public class MoveObject : MonoBehaviour {
    // Two positions stored as vector3 array
    private Vector3[] pedestrian1 = {   new Vector3 ( 10, 0.5f, 10 ),
                                        new Vector3 ( 10, 0.5f, -45 )};
    private Vector3[] pedestrian2 = {   new Vector3 ( -10, 0.5f, -9.5f ),
                                        new Vector3 ( -93, 0.5f, -9.5f )};
    private Vector3[] car1 = {   new Vector3 ( 3, 0, 2 ),
                                 new Vector3 ( 3, 0, -42 )};
    private Vector3[] car2 = {   new Vector3 ( -4, 0, -3 ),
                                 new Vector3 ( -85, 0, -3 )};

    public float vechicleSpeed = 0.25f;
    public float pedestrianSpeed = 0.1f;

    // Update is called once per frame
    void Update() {
        // Car 1 object
        if (gameObject.name == "Car1") {
            transform.position = Vector3.Lerp(car1[0], car1[1], Mathf.PingPong(Time.time * vechicleSpeed, 1)); // ping pong between 2 postions
            // Rotate to face direction of movement
            if (transform.position.z >= 1.5f) {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
            else if (transform.position.z <= -41.5f) {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }
        // Car 2 object
        else if (gameObject.name == "Car2") {
            transform.position = Vector3.Lerp(car2[0], car2[1], Mathf.PingPong(Time.time * vechicleSpeed, 1)); // ping pong between 2 postions
            // Rotate to face direction of movement
            if (transform.position.x >= -4.5f) {
                transform.eulerAngles = new Vector3(0, 270, 0);
            }
            else if (transform.position.x <= -84.5f) {
                transform.eulerAngles = new Vector3(0, 90, 0);
            }
        }
        // Pedestrian 1 object
        else if (gameObject.name == "Pedestrian1") {
            transform.position = Vector3.Lerp(pedestrian1[0], pedestrian1[1], Mathf.PingPong(Time.time * pedestrianSpeed, 1)); // ping pong between 2 postions
            // Rotate to face direction of movement
            if (transform.position.z >= 9.5f) {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
            else if (transform.position.z <= -44.5f) {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }
        // Pedestrian 2 object
        else if (gameObject.name == "Pedestrian2") {
            transform.position = Vector3.Lerp(pedestrian2[0], pedestrian2[1], Mathf.PingPong(Time.time * pedestrianSpeed, 1)); // ping pong between 2 postions
            // Rotate to face direction of movement
            if (transform.position.x >= -10.5f) {
                transform.eulerAngles = new Vector3(0, 270, 0);
            }
            else if (transform.position.x <= -92.5f) {
                transform.eulerAngles = new Vector3(0, 90, 0);
            }
        }
    }
}
