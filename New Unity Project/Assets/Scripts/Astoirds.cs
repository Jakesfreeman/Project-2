using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astoirds : MonoBehaviour
{
    private Transform tf; // A variable to hold our Transform component
    public float speed;
    private Vector3 direction;
    private Rigidbody2D rb2;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        direction = (tf.position - GameManager.instance.player.position).normalized;
        tf.up = direction; //looks for players last location and goes to it
    }

    // Update is called once per frame
    void Update()
    {
        
        tf.position += -tf.up * speed * Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameManager.instance.Activeenemies.Remove(gameObject);
        }

        Destroy(other.gameObject);
    }

}