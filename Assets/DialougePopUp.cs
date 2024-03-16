using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougePopUp : MonoBehaviour
{
    [SerializeField] GameObject dialogeMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            dialogeMenu.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            dialogeMenu.SetActive(false);
        }
        
    }
}
