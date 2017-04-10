using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TManager : MonoBehaviour
{
    public EIText_ eIText;
    public UIM_Talk uim_talk;
    public int i; 


    // intberekennen
    //void, int ,berekening, haalt op, doorstuuren
    public void Oproep (int i)
        {
        eIText.Ja(i);
        }

}

