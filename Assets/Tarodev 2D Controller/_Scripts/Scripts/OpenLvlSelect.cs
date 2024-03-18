using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLvlSelect : MonoBehaviour
{
    public Animator transtion;
    // Start is called before the first frame update
   

    // Update is called once per frame
    public void OpenLvlSelector() {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transtion.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Level Selection");

    }
}
