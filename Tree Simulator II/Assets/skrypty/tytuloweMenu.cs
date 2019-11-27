using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tytuloweMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void doGry()
    {
        SceneManager.LoadScene(1);
    }

    public void doTytulowego()
    {
        SceneManager.LoadScene(0);
    }

}
