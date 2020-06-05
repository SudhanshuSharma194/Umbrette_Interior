using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    private bool doorOpened;
    private bool coroutineAllowed;
    // Start is called before the first frame update
    void Start()
    {
        doorOpened = false;
        coroutineAllowed = true;
    }

    private void OnMouseDown()
    {
        Invoke("RunCoroutine", 0f);
    }
    private void RunCoroutine()
    {
        StartCoroutine("OpenThatDoor");
    }
    
    private IEnumerator OpenThatDoor()
    {
        coroutineAllowed = false;
        if (!doorOpened)
        {
            for (float i = 0f; i <= 90f; i += 3f)
            {
                transform.localRotation = Quaternion.Euler(0f, 0f, -i);
                yield return new WaitForSeconds(0f);
            }
            doorOpened = true;
        }
        else
        {
            for (float i = 90f; i >= 0f; i -= 2f)
            {
                transform.localRotation = Quaternion.Euler(0f, 0f, -i);
                yield return new WaitForSeconds(0f);
            }
            doorOpened = false;
        }
        coroutineAllowed = true;
    }
    
}
