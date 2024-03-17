using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Question_Selector : MonoBehaviour
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
            OpenQuestion();
        }
     }

    public void OpenQuestion() {
        SceneManager.LoadScene("Question " + level.ToString());
    }
}
