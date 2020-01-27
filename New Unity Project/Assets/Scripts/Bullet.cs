using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //declareing variables
    private Transform tf;
    public float speed;



    // Start is called before the first frame update
    void Start()
    {
        //getting the transform component
        tf = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // giving our bullet motion
        tf.position += tf.up * speed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy") // looks at other game object tags
        {
            //looks at list of active enemies and removes one on collision
            GameManager.instance.Activeenemies.Remove(other.gameObject);
            Destroy(other.gameObject); // destorys the game object
            GameManager.instance.score += 10; // adds score
            GameManager.instance.scoreUI.text = GameManager.instance.score.ToString(); // updates UI to current score
        }
    }
}
