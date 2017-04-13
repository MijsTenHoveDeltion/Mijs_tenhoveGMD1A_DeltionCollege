using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TManager : MonoBehaviour
{
    public EIText_ eIText;
    public UIM_Talk uim_talk;
    public int ipos;
   
    

    public void Doorturen(int i)
    {
        uim_talk.TextTerug(eIText.vraag[ipos += i]);
    }
}




