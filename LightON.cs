using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightON : MonoBehaviour
{
    public Light MyLight;
    public bool lightBool;

    private void Start()
    {
        MyLight = GetComponentInChildren<Light>();
    }

    public void TurnLightOn()
    {
        if (lightBool)
        {
            MyLight.enabled=true;
            lightBool = !lightBool;
        }
        else if(lightBool != true)
        {
            MyLight.enabled = false;
            lightBool = !lightBool;
        }
        
        
    }

}
