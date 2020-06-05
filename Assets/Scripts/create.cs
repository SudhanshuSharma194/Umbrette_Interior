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
    public GameObject ObjectsDD;
    public GameObject WallTexturesDD;
    public GameObject FloorTexturesDD;
    public Text label;
    public GameObject sofa;
    public GameObject chair;
    public GameObject Door;
    public GameObject Table;


    int l,b,h;
    

    void Start()
    {
        int.TryParse(length.text, out l );
        int.TryParse(breadth.text, out b);
        int.TryParse(height.text, out h);
        gameObject.transform.localScale = new Vector3(l, b, h);
    }

    

    
    public void form()
    {
        panel.SetActive(false);
        
        gameObject.SetActive(true);
        ObjectsDD.SetActive(true);
        WallTexturesDD.SetActive(true);
        FloorTexturesDD.SetActive(true);


    }
    public void placeobject()
    {
        if (label.text == "Sofa")
            sofa.SetActive(true);
        else if (label.text == "Chair")
            chair.SetActive(true);
        else if (label.text == "Door")
            Door.SetActive(true);
        else if (label.text == "Table")
            Table.SetActive(true);
    }
}
