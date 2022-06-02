using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    [SerializeField] float speed = 15;

    void Update()
    {

        var Pos = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        var PosY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Rotate(0, Pos * 3,0, Space.Self);
        transform.Translate(new Vector3(0, 0,PosY ));
    }

 
}
