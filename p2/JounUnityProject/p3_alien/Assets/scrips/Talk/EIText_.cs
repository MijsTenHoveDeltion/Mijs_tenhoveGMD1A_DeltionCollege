using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class EIText_ : MonoBehaviour
{
    public UIM_Talk uimt;
    public TManager tMM;
    public List<string> vraagTest = new List<string>();
    public List<string> antwoordTest1 = new List<string>();
    public List<string> antwoordTest2 = new List<string>();

    public void TJa (int i)
    {
        tMM.OproepJa(i);
        uimt.ChangeButton(antwoordTest1[i], antwoordTest2[i]);
    }
    public void Antw(int i)
    {
        print("ho");
     //   uimt.ChangeVraag(vraagTest[i]);
     //   TMM.Oproepvraag((i)vraagTest[i]);
    }

}

   
       


    

