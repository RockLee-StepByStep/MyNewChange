using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlock : MonoBehaviour
{
    [SerializeField] Vector3 pos;
    [SerializeField] Vector2 mousePosition;

    public Transform Hand;
    Ray ray;

    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        pos = ray.GetPoint(3);
        Hand.transform.position = new Vector3(pos.x ,pos.y ,pos.z);    
    }
}

   

