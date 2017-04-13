using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TManager : MonoBehaviour
{
    public EIText_ eIText;
    public UIM_Talk uim_talk;
    public int ipos;
    public GameObject water;
    public int gesprek2;

    public void Doorturen(int i)
    {
        print("kay");
        // ipos += gesprek2; 
      
        uim_talk.TextTerug(eIText.vraag[ipos += i]);
       



    }
}




