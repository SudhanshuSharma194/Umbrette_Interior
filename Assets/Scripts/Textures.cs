using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textures : MonoBehaviour
{
    public Texture[] textures;
    public Texture DefaultTexture;
    public Text selectedoption;
    private int t;

    public void SelectTexture()
    {
        if (selectedoption.text == "None")
        {
            GetComponent<Renderer>().material.mainTexture = DefaultTexture;
            return;
        }           
        int.TryParse(selectedoption.text, out t);
        t--;
        GetComponent<Renderer>().material.mainTexture = textures[t];
    }
}
