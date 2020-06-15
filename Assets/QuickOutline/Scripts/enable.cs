﻿using UnityEngine;
using UnityEngine.UI;

public class enable : MonoBehaviour
{
    Outline script;
    public GameObject obj;
    public GameObject Animation;
    public GameObject Rotation;
    public GameObject OKbutton;


    // Start is called before the first frame update
    void Start()
    {

        script = obj.GetComponent<Outline>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        script.enabled = true;
        Animation.GetComponent<Button>().interactable = true;
        
        Rotation.GetComponent<Toggle>().interactable = true;
        OKbutton.SetActive(true);
    }
    public void OnClickOKButton()
    {
        script.enabled = false;
        Animation.GetComponent<Button>().interactable = false;
        
        Rotation.GetComponent<Toggle>().interactable = false;
        OKbutton.SetActive(false);
    }
}
