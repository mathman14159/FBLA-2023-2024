using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Selector : MonoBehaviour
{
    public int level;
    public Animator transtion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene() {
        StartCoroutine(LoadLevelChoose());
    }

    IEnumerator LoadLevelChoose()
    {
        transtion.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Level " + level.ToString());

    }
}
