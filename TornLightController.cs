using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornLightController : MonoBehaviour
{
    [SerializeField]LightON[] lights;
    void Start()
    {
        lights = FindObjectsOfType<LightON>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            Debug.Log(1);
            for (int i = 0;i<lights.Length; i++)
            {
               
                lights[i].TurnLightOn();
            }
        }
    }
}
