using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
    [SerializeField] GameObject HTPMenu;
    [SerializeField] GameObject MainMenu;
    

    // Update is called once per frame
    

    public void HTP()
    {
        HTPMenu.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void HTPoff()
    {
        HTPMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

}