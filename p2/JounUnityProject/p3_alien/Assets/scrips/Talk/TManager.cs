using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TManager : MonoBehaviour
{
    public EIText_ eIText;
    public UIM_Talk uim_talk;
    public int i;
    public int ix = 2;


    // intberekennen
    //void, int ,berekening, haalt op, doorstuuren
    public void OproepJa (int i)
    {
        print("da");
        eIText.TJa(i * ix);
       uim_talk.aaa("antwor");
    }
    public void Oproepvraag(int i)
    {
        print("ka");
        eIText.Antw(i * ix);
    }
        

}



