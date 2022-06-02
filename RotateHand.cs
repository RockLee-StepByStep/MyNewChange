using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHand : MonoBehaviour
{
    void Start()
    {
        transform.eulerAngles = new Vector3(
            transform.eulerAngles.x + 30,
            transform.eulerAngles.y + 180,
            transform.eulerAngles.z
            );    
    }

}
