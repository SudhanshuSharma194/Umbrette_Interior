using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enable : MonoBehaviour
{
    Outline script;
    public GameObject obj;

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
    }
    private void OnMouseUp()
    {
        script.enabled = false;
    }
}
