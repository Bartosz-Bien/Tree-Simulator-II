using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SklepSkrypt : MonoBehaviour
{
    public static bool czySklepOtwarty = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            otworzSklep();
        }
    }

    public void otworzSklep()
    {

    }
}
