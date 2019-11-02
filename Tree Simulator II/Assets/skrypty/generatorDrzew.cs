using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorDrzew : MonoBehaviour
{
    public GameObject wiosna;
    public GameObject lato;
    public GameObject jesien;
    public GameObject zima;
    public GameObject owoce;
    public int ilosc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject farmer = GameObject.Find("farmer-pixilart");
        staty staty = farmer.GetComponent<staty>();
        ilosc = (int)staty.iloscDrzew;

        for (int i = 1; i < ilosc+1; i++)
        {
            if (i % 2 == 1)
                Instantiate(jesien, new Vector3(i * 2f, 0f, 0f), Quaternion.identity);
            else
                Instantiate(jesien, new Vector3(i * (-2f), 0f, 0f), Quaternion.identity);            
        }
    }

    public void generujDrzewa()
    {

    }
}
