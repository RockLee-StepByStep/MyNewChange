using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{

    private Vector3 mOffset;
    private float mZCoord;

   

    [SerializeField]public bool Takeable;



    private void OnMouseDown()
    {   
        
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();



    }

    private Vector3 GetMouseWorldPos()
    {
        // pixel coordinat(x,y)
        Vector3 mousePoint = Input.mousePosition;
         
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        
        transform.position = GetMouseWorldPos() + mOffset; 
    }


}
