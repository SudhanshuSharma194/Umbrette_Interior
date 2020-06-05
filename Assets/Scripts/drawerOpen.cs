using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawerOpen : MonoBehaviour
{
    private bool boxOpened;
    private bool coroutineAllowed;
    private Vector3 initialposition;
    
    // Start is called before the first frame update
    void Start()
    {
        boxOpened = false;
        coroutineAllowed = true;
        initialposition = transform.position;
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
        if (!boxOpened)
        {
            for (float i = -0.00346f; i >= -0.00767f; i -= 0.001f)
            {
                transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.001f, transform.localPosition.z);
                yield return new WaitForSeconds(0f);
            }
            boxOpened = true;
        }
        else
        {
            for (float i = -0.00767f; i <= -0.00346f; i += 0.001f)
            {
                transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.001f, transform.localPosition.z);
                yield return new WaitForSeconds(0f);
            }
            transform.position = initialposition;
            boxOpened = false;
        }
        coroutineAllowed = true;
    }
}
