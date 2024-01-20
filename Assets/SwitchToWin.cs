using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToWin : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            OpenWin();
        }
     }

    // Update is called once per frame
    public void OpenWin() {
        SceneManager.LoadScene("Win lvl " + level.ToString());
    }
}
