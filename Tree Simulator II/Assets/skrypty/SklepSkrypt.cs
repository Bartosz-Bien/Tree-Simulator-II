using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SklepSkrypt : staty
{
    public static bool czySklepOtwarty = false;
    public GameObject sklepUI;
    public Text cenaDrzewaTekst;
    public Text cenaNawozuTekst;
    public Text cenaPestycyduTekst;
        
    private void Start()
    {
        sklepUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (czySklepOtwarty)
            {
                nastepnyMiesiac();
            }
            else
            {
                otworzSklep();
            }
        }*/
    }

    
    
                
    public void otworzSklep()
    {
        // sie wyswietla canvas jak wywolana funkcja        
        sklepUI.SetActive(true);
        czySklepOtwarty = true;
        cenaDrzewaTekst.text = "One tree costs: " + cenaDrzewa;
        //Debug.Log(cenaNawozu);
        cenaNawozuTekst.text = "One fertilizer costs: " + cenaNawozu;//"One fertilizer costs: " + cenaDrzewa;
        //Debug.Log(cenaNawozu);
        // Debug.Log(cenaPestycydu);
        cenaPestycyduTekst.text = "One pesticide costs: " + cenaPestycydu;
    }

    public void nastepnyMiesiac()
    {
        sklepUI.SetActive(false);
        czySklepOtwarty = false;
        miesiac++;       
    }

    public void kupDrzewo()
    {
        if ((iloscPieniedzy >= cenaDrzewa) && iloscDrzew < 14)
        {
            iloscDrzew++;
            iloscPieniedzy -= cenaDrzewa;           
        }        
    }

             
    public void kupNawoz()
    {
        if (iloscPieniedzy >= cenaNawozu)
        {
            iloscNawozu++;
            iloscPieniedzy -= cenaNawozu;
        }
    }

    public void kupPestycyd()
    {
        if (iloscPieniedzy >= cenaPestycydu)
        {
            iloscPestycydu++;
            iloscPieniedzy -= cenaPestycydu;
        }
    }
}
