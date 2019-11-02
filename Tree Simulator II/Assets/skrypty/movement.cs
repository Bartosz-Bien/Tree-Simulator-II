using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float x, y;
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        speed = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxis("Vertical") * 30 * speed * Time.fixedDeltaTime;
        x = Input.GetAxis("Horizontal") * 30 * speed * Time.fixedDeltaTime;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(x, y));
    }
}
