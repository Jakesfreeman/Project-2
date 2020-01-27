using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBox : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other)
    { // if anything leaves the play area it will be destroyed
        if (other.CompareTag("Enemy"))
        {
            GameManager.instance.Activeenemies.Remove(other.gameObject); // removes enemies from the active enemy list
        }
        Destroy(other.gameObject);
    }
}
