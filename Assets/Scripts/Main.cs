using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public Text Length;
    public Text Breadth;
    public Text Height;
    public static string length;
    public static string breadth;
    public static string height;
    void Start()
    {
        length = Length.text;
        breadth = Breadth.text;
        height = Height.text;
    }

    // Update is called once per frame
    void Update()
    {
        length = Length.text;
        breadth = Breadth.text;
        height = Height.text;
    }

    public void OnClickCreateButton()
    {
        SceneManager.LoadScene("Home");
    }
    public void OnClickExitButton()
    {
        Application.Quit();
    }
}
