using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hurtPlayer : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            OpenDeath();
        }
     }
     public void OpenDeath() {
        SceneManager.LoadScene("Death lvl " + level.ToString());
    }
}
