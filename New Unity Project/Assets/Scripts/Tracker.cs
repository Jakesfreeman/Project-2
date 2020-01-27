using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    private Transform tf; // A variable to hold our Transform component
    public float speed;
    private Vector3 direction;
    private Rigidbody2D rb2;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {
        direction = (tf.position - GameManager.instance.player.position).normalized; // looks for the player at all times
        tf.up = direction;

        tf.position += -tf.up * speed * Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameManager.instance.Activeenemies.Remove(gameObject); // once destroyed removed from active enemies list
        }

        Destroy(other.gameObject);
    }
}
