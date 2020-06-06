using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dragObject : MonoBehaviour
{
    public Toggle toggle;
    float rotspeed = 50;
    private Vector3 mOffset;
    private float mZCoord;

    
     
    void OnMouseDown()

    {
       if(toggle.isOn==false)
        {
            mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        }
    }



    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;



        // z coordinate of game object on screen

        mousePoint.z = mZCoord;



        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {

        if(toggle.isOn)
        {
            float rotx = Input.GetAxis("Mouse X") * rotspeed * Mathf.Deg2Rad;
            float roty = Input.GetAxis("Mouse Y") * rotspeed * Mathf.Deg2Rad;

            transform.Rotate(Vector3.up, -rotx);
            transform.Rotate(Vector3.right, roty);

        }
        else
            transform.position = GetMouseAsWorldPoint() + mOffset;


    }
}
