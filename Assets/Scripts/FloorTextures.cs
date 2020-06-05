using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorTextures : MonoBehaviour
{
    public Texture[] textures;
    public Text SelectedOption;
    public Texture DefaultTexture;
    private int t;
    public void SelectTexture()
    {
        

            if (SelectedOption.text == "None")
            {
                GetComponent<Renderer>().material.mainTexture = DefaultTexture;
                return;
            }

            int.TryParse(SelectedOption.text, out t);
            t--;
            GetComponent<Renderer>().material.mainTexture = textures[t];
        
    }
}
