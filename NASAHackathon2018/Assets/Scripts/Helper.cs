using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helper : MonoBehaviour
{

    public float delay, wordDelay;
    public GameObject canv, textObj;
    float time = 0.0f;
    bool doing = false;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            StartCoroutine( say("Acest program functioneaza!"));
        }

 
    }

    IEnumerator say(string strComplete)
    {
        int i = 0;
        textObj.GetComponent<Text>().text = "";
        while (i < strComplete.Length)
        {
            textObj.GetComponent<Text>().text += strComplete[i++];
            if (strComplete[i]==' ')
                yield return new WaitForSeconds(wordDelay);
            else yield return new WaitForSeconds(delay);
        }
    }

}
