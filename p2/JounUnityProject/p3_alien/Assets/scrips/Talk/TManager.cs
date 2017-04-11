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
    public void OproepJa (int i)
        {
        eIText.TJa(i);
        }
    public void Oproepvraag()
    {

    }

}

