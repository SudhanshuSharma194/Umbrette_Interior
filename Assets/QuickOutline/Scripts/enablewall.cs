using UnityEngine;
using UnityEngine.UI;

public class enablewall : MonoBehaviour
{
    Outline script;
    public GameObject obj;
    public GameObject Texture;
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
        Texture.GetComponent<Dropdown>().interactable = true;
        OKbutton.SetActive(true);
    }
    public void OnClickOKButton()
    {
        script.enabled = false;
        Texture.GetComponent<Dropdown>().interactable = false;
        OKbutton.SetActive(false);
    }
}
