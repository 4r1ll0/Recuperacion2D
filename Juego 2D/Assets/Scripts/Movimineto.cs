using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimineto : MonoBehaviour
{

    public float speed;
    public float dirX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");

        transform.position += new Vector3(dirX * speed, 0, 0);


    }
}
