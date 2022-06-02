using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaOfTaking : MonoBehaviour
{
    public bool ThingTakeAbble;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Selectable"))
        {
            Debug.Log("Sucses!");
            ThingTakeAbble = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Selectable"))
        {
            Debug.Log("AreaExit!");
            ThingTakeAbble = false;
        }   
    }
}
