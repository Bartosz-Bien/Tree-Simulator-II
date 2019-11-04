using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class staty : MonoBehaviour
{
    public static int iloscDrzew;
    public int miesiac, miesiaceGry, iloscNawozu, iloscPieniedzy, cenaDrzewa, cenaNawozu;
    public Text statsText;

    // Start is called before the first frame update
    void Start()
    {
        iloscDrzew = 7;
        miesiac = 0;
        iloscNawozu = 99;
        iloscPieniedzy = 99999;

        miesiaceGry = 60;

        statsText.text = "Trees: " + iloscDrzew + ", Coins: " + iloscPieniedzy + ", Fertilizers: " + iloscNawozu + ", Month: " + miesiac % 12 + ", Year: " + miesiac / 12 + ", Remains: " + (miesiaceGry - miesiac) + " months";
    }

    // Update is called once per frame
    void Update()
    {
        statsText.text = "Trees: " + iloscDrzew + ", Coins: " + iloscPieniedzy + ", Fertilizers: " + iloscNawozu + ", Month: " + miesiac % 12 + ", Year: " + miesiac / 12 + ", Remains: " + (miesiaceGry - miesiac) + " months";
    }

    
}
