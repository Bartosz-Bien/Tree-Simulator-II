using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorDrzew : staty
{
    // max ilosc drzew = 14
    public List<GameObject> wiosna;
    public List<GameObject> lato;
    public List<GameObject> jesien;
    public List<GameObject> zima;
    public List<GameObject> owoce;
    
    void Start()
    {
        Renderer zimaR = zima[0].GetComponent<Renderer>();
        zimaR.enabled = true;
    }
    
    public void generujDrzewa()
    {
        GameObject rycerz = GameObject.Find("eventSkrypt");
        eventy hpscript = rycerz.GetComponent<eventy>();
        czyScieloDrzewo = hpscript.czyScieloDrzewo;

        Debug.Log(czyScieloDrzewo);
        if (miesiac % 12 == 10) // wypłata za plony
            iloscPieniedzy += (1000 * iloscDrzew);

        for (int i = 0; i < iloscDrzew; i++)
        {
            Renderer wiosnaR = wiosna[i].GetComponent<Renderer>();
            wiosnaR.enabled = false;            
        }
        if (czyScieloDrzewo && miesiac % 12 >= 3 && miesiac % 12 <= 5)
        {
            Renderer wiosnaR = wiosna[iloscDrzew].GetComponent<Renderer>();
            wiosnaR.enabled = false;
            czyScieloDrzewo = false;
            //iloscDrzew--;
            Debug.Log(miesiac);
        }
        if (miesiac % 12 >= 3 && miesiac % 12 <= 5)
        {            
            for (int i = 0; i < iloscDrzew; i++)
            {
                Renderer wiosnaR = wiosna[i].GetComponent<Renderer>();
                wiosnaR.enabled = true;
            }            
        }

        for (int i = 0; i < iloscDrzew; i++)
        {
            Renderer latoR = lato[i].GetComponent<Renderer>();
            latoR.enabled = false;
        }
        if (czyScieloDrzewo && miesiac % 12 >= 6 && miesiac % 12 <= 8)
        {
            Renderer latoR = lato[iloscDrzew].GetComponent<Renderer>();
            latoR.enabled = false;
            czyScieloDrzewo = false;
            //iloscDrzew--;
            Debug.Log(miesiac);
        }
        if (miesiac % 12 >= 6 && miesiac % 12 <= 8)
        {
            for (int i = 0; i < iloscDrzew; i++)
            {
                Renderer latoR = lato[i].GetComponent<Renderer>();
                latoR.enabled = true;
            }
        }


        for (int i = 0; i < iloscDrzew; i++)
        {
            Renderer owoceR = owoce[i].GetComponent<Renderer>();
            owoceR.enabled = false;
        }
        if (czyScieloDrzewo && miesiac % 12 == 9)
        {
            Renderer owoceR = owoce[iloscDrzew].GetComponent<Renderer>();
            owoceR.enabled = false;
            czyScieloDrzewo = false;
            //iloscDrzew--;
            Debug.Log(miesiac);
        }
        if (miesiac % 12 == 9)
        {
            for (int i = 0; i < iloscDrzew; i++)
            {
                Renderer owoceR = owoce[i].GetComponent<Renderer>();
                owoceR.enabled = true;
            }
            
        }

        for (int i = 0; i < iloscDrzew; i++)
        {
            Renderer jesienR = jesien[i].GetComponent<Renderer>();
            jesienR.enabled = false;
        }
        if (czyScieloDrzewo && miesiac % 12 >= 10 && miesiac % 12 <= 11)
        {
            Renderer jesienR = jesien[iloscDrzew].GetComponent<Renderer>();
            jesienR.enabled = false;
            czyScieloDrzewo = false;
            //iloscDrzew--;
            Debug.Log(miesiac);
        }
        if (miesiac % 12 >= 10 && miesiac % 12 <= 11)
        {
            for (int i = 0; i < iloscDrzew; i++)
            {
                Renderer jesienR = jesien[i].GetComponent<Renderer>();
                jesienR.enabled = true;

            }
        }
                      
        for (int i = 0; i < iloscDrzew; i++)
        {
            Renderer zimaR = zima[i].GetComponent<Renderer>();
            zimaR.enabled = false;
        }
        if (czyScieloDrzewo && miesiac % 12 >= 0 && miesiac % 12 <= 2)
        {
            Renderer zimaR = zima[iloscDrzew].GetComponent<Renderer>();
            zimaR.enabled = false;
            czyScieloDrzewo = false;
            //iloscDrzew--;
            Debug.Log(miesiac);
        }
        if (miesiac % 12 >= 0 && miesiac % 12 <= 2)
        {
            for (int i = 0; i < iloscDrzew; i++)
            {
                Renderer zimaR = zima[i].GetComponent<Renderer>();
                zimaR.enabled = true;
            }
        }
    }
}
