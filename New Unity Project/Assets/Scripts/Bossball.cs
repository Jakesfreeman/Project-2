using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossball : MonoBehaviour
{
    private Transform tf; // A variable to hold our Transform component
    public float speed;
    private Vector3 direction;


    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        direction = (tf.position - GameManager.instance.player.position).normalized;
        tf.up = direction; //setting direction as where the player is

        tf.position += -tf.up * speed * Time.deltaTime; // gives speed to the bosses shot
        Destroy(gameObject, 3.5f); // gives the bosses shot a lifespan
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "player") // looks for the player tag 
        {
            
            Destroy(other.gameObject);
            
        }
    }
}
