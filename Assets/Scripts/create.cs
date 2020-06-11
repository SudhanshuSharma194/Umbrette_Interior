using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class create : MonoBehaviour
{
    public GameObject ObjectsDD;
    public Text label;
    public GameObject sofa;
    public GameObject chair;
    public GameObject Door;
    public GameObject Table;
    public GameObject toggle;


    int l,b,h;
    

    void Start()
    {
        int.TryParse(Main.length, out l );
        int.TryParse(Main.breadth, out b);
        int.TryParse(Main.height, out h);
        gameObject.transform.localScale = new Vector3(l, b, h);
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
