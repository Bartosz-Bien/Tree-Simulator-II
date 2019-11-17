using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauza : MonoBehaviour
{
    public GameObject pauzaUI;

    // Start is called before the first frame update
    void Start()
    {
        pauzaUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauzaUI.SetActive(true);
        }
    }
    public void wyjscieZGry()
    {
        Application.Quit();
    }
    public void powrotDoGry()
    {
        pauzaUI.SetActive(false);
    }

}
