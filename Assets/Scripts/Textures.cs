using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textures : MonoBehaviour
{

    public Texture[] textures;
    public Texture DefaultTexture;
    public Text selectedoption;
    public GameObject TexturesDropDown;
    private int t;


    private void OnMouseDown()
    {
        StartCoroutine(TexturesOption());
    }
    void Update()
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
    private IEnumerator TexturesOption()
    {

        TexturesDropDown.SetActive(true);
        yield return new WaitForSeconds(5);
        TexturesDropDown.SetActive(false);


    }
}
