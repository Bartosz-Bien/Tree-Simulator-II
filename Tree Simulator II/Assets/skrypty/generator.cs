using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    public int width=2;
    public GameObject mapa;
    public GameObject kraniec;
    public GameObject ziemia;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(kraniec, new Vector3(width * 13f, 0f, 0f), Quaternion.identity);
        Instantiate(ziemia, new Vector3(width * 13f, -10f, 0f), Quaternion.identity);

        for (int i = 0; i < width; i++)
        {
            Instantiate(mapa, new Vector3(i * 13f, 0f, 0f), Quaternion.identity);
            Instantiate(mapa, new Vector3(i * (-13f), 0f, 0f), Quaternion.identity);
            Instantiate(ziemia, new Vector3(i * 13f, -10f, 0f), Quaternion.identity);
            Instantiate(ziemia, new Vector3(i * (-13f), -10f, 0f), Quaternion.identity);
        }

        Instantiate(kraniec, new Vector3(width * (-13f), 0f, 0f), Quaternion.identity);
        Instantiate(ziemia, new Vector3(width * (-13f), -10f, 0f), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
