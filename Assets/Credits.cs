using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    [SerializeField] GameObject CreditsMenu;
    [SerializeField] GameObject MainMenu;
    

    // Update is called once per frame
    

    public void Creditopen()
    {
        CreditsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void Creditsoff()
    {
        CreditsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

}