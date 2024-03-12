using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponet;
    public string[] lines;
    public float textSpeed;

    private int index;
    // Start is called before the first frame update
    void IEnumerator()
    {
        textComponet.text = string.Empty;
        //StartDialouge();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void StartDialouge()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponet.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    private void OnEnable() {
    {
        
        StartDialouge();
    }
    }
}



   

