using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class UIM_Talk : MonoBehaviour
{ 
   public TManager tM;
    public Canvas canvasText;
    public GameObject praat;
    public Button jaa;
    public Button neee;


    public void Start()
    {
        canvasText.enabled = false;

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && praat.tag == "Alien")
        {
            canvasText.enabled = true;
        }

    }

    public void Antwoord()
    {
        tM.Oproep(1);
    }
        
          
            //
        
            

        // int/punten
        //knoplingke/ je antwoord Ja/Nee
        // aan de TM de TM stuurt naar de EIText_
}


