using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawners : MonoBehaviour
{
    public List<Transform> spawnpoints; // goes through a list of spawn points then spawns an enemies at one
    public List<GameObject> enemies; // list of enemies that can be spawned
    public int maxenemies; // limits how many enemies can be on screen

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {

        if( !GameManager.instance.boss) // wont spawn other enemies once the boss spawns but will after he is defeated
        {
            if (GameManager.instance.Activeenemies.Count < maxenemies)
            {
                spawnenemy();
            }
        }
        
    }

    void spawnenemy() //a function to spawn enemies
    {
        int type = Random.Range(0, enemies.Count); // chooses a random enemy
        int spawn = Random.Range(0, spawnpoints.Count); // chooses a random spawn
        GameObject enemy = Instantiate(enemies[type], spawnpoints[spawn]); //Instantiates the enemy and spawn
        GameManager.instance.Activeenemies.Add(enemy); // adds the enemy to the active enemies list
    }
}
