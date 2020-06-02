using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("x"))
        {
            transform.localScale += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown("y"))
        {
            transform.localScale += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown("z"))
        {
            transform.localScale += new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown("c"))
        {
            transform.localScale -= new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown("u"))
        {
            transform.localScale -= new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown("v"))
        {
            transform.localScale -= new Vector3(0, 0, 1);
        }
    }
    
}
