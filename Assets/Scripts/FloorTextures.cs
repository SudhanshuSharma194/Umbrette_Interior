using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTextures : MonoBehaviour
{
    public Texture[] textures;
    public int currentTexture;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            currentTexture++;
            currentTexture %= textures.Length;
            //Renderer.material.mainTexture = textures[currentTexture];
            GetComponent<Renderer>().material.mainTexture = textures[currentTexture];
        }
    }
}
