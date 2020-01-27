using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankcontrol : MonoBehaviour
{
    private Transform tf; // A variable to hold our Transform component
    public float speed;
    public float rotatespeed;
    private Vector3 randomVector;

    public GameObject missle;
    void Start()
    {
        // Get the Transform Component
        tf = GetComponent<Transform>();
    }

    void Update()
    {
        


        //movement if statements for moving once a key press while hold left shift


        if (Input.GetKey(KeyCode.LeftArrow)) // rotates left
        {
            tf.Rotate(0.0f, 0.0f, rotatespeed);
        }

        if (Input.GetKey(KeyCode.RightArrow)) //rotates right
        {
            tf.Rotate(0.0f, 0.0f, -rotatespeed);
        }

        if (Input.GetKey(KeyCode.UpArrow)) //move forward
        {
            tf.position += tf.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow)) // move back
        {
            tf.position += -tf.up * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space)) //fire
        {
            Instantiate(missle, tf.position + tf.up *1.0f , tf.rotation);
            
        }

        if (Input.GetKey(KeyCode.X)) // teleport within a circle
        {
            randomVector = Random.insideUnitCircle;
            randomVector *= 2;
            Vector3 newPosition = tf.position + randomVector;
            tf.position = newPosition;
        }
    }
}