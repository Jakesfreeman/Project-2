using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    // setting up variables to work with
    public static GameManager instance;
    public Transform player;
    public int score;
    public Text scoreUI;
    public GameObject Boss;
    public Transform tf;
    public bool boss;
    public int hp = 10;
    public List<GameObject> Activeenemies = new List<GameObject>(); // setting a list for active enemies
    void Awake()
    {
        // As long as there is not an instance already set
        if (instance == null)
        {
            instance = this; // hold the scene that we are in
            DontDestroyOnLoad(gameObject); // Don't delete this object if we load a new scene
        }
        else
        {
            Destroy(this.gameObject); // destorys second game manager
            Debug.Log("Warning: A second game manager was detected and destroyed.");
        }
    }

    void Update()
    {

        // setting a score to when the boss spawns
        if (score == 100 && !boss)
        {
            Instantiate(Boss, tf);
            boss = !boss;
            

        }
    }
}