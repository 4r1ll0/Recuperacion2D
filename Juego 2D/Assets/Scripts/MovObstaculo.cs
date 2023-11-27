using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovObstaculo : MonoBehaviour
{
    Transform t;
    bool haciaArriba = true;
    bool haciaAbajo = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 3)
        {
            haciaArriba = false;
        }



        if (haciaArriba == true)
        {
            transform.position += Vector3.up * Time.deltaTime;
        }
        else
        {
            transform.position -= Vector3.up * Time.deltaTime;

        }

     
    }
}
