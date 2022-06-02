using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class acivatorTv : MonoBehaviour
{
    [SerializeField] TornTvOn torn;
    [SerializeField] bool TvActive;
    
    private void Start()
    {
        torn = GameObject.FindObjectOfType<TornTvOn>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Hand"))
        {
            Debug.Log("TV on");
            TvActive = true;
            if (TvActive)
            {
                Debug.Log("TV OOOOOn");
                torn.TurnClipPlease();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            Debug.Log("TV Off");
            TvActive = false;
            if (TvActive)
            {
                Debug.Log("TV ossn");
            }
        }
    }

}
