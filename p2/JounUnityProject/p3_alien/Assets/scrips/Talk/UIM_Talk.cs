using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class UIM_Talk : MonoBehaviour
{ 
    public TManager tM;
    public Canvas canvasText;
    public GameObject praat;
    public GameObject waterpraat;
    public Text aiVraag;

    

    public void Start()
    {
        canvasText.enabled = false;
    }
    public void Canvasklije(GameObject TalkObject)
    {

        if (TalkObject.gameObject.tag == ("Alien"))
        {
            canvasText.enabled = true;
            
        }
        if (TalkObject.gameObject.tag == ("water"))
        {
            canvasText.enabled = true;
        }
    }


    public void ButtonKlik(int i)
    {
        tM.Doorturen(i);   
    }

    public void TextTerug(string vraag)
    {
        aiVraag.text = vraag;
        if (vraag == "...")
        {
            canvasText.enabled = false;
        }
    }
}


