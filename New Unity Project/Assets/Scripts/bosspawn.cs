using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosspawn : MonoBehaviour
{
    public float fireRate;
    private float nextFire;
    public GameObject shot;
    private Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Time.time > nextFire) // setting a fire rate for the boss
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, tf.position + tf.up * 1.85f, tf.rotation);
        }
        if (GameManager.instance.hp == 0) // setting the bosses Health
        {
            Destroy(gameObject);
            GameManager.instance.boss = !GameManager.instance.boss ;
        }
    }
    void OnCollisionEnter2D(Collision2D other) //looking for the player
    {
        GameManager.instance.hp -= 1;
        if (other.gameObject.tag == "player")
        {
            Destroy(other.gameObject);
        }
        Destroy(other.gameObject);
    }
}
