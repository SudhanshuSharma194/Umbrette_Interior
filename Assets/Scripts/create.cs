using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class create : MonoBehaviour
{
    public GameObject panel;
    public Text length;
    public Text breadth;
    public Text height;
    public GameObject dd;
    public Text label;
    public GameObject sofa;
    public GameObject chair;

    float rotspeed = 40;
    int l,b,h;
    
    // Start is called before the first frame update
    void Start()
    {
        int.TryParse(length.text, out l );
        int.TryParse(breadth.text, out b);
        int.TryParse(height.text, out h);
        gameObject.transform.localScale = new Vector3(l, b, h);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void form()
    {
        panel.SetActive(false);
        
        gameObject.SetActive(true);
        dd.SetActive(true);

    }
    public void placeobject()
    {
        if (label.text == "Sofa")
            sofa.SetActive(true);
        else if (label.text == "Chair")
            chair.SetActive(true);
    }
}
