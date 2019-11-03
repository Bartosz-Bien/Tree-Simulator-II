using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SklepSkrypt : MonoBehaviour
{
    public static bool czySklepOtwarty = false;
    public GameObject sklepUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (czySklepOtwarty)
            {
                nastepnyMiesiac();
            }
            else
            {
                otworzSklep();
            }
        }
    }

    public void otworzSklep()
    {
        // sie wyswietla canvas jak wywolana funkcja
        sklepUI.SetActive(true);
        czySklepOtwarty = true;
    }

    public void nastepnyMiesiac()
    {
        sklepUI.SetActive(false);
        czySklepOtwarty = false;
    }

    public void kupDrzewo()
    {
        
    }
}
