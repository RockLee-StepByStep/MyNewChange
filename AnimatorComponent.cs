using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorComponent : MonoBehaviour
{
    AreaOfTaking takeArea;
    Animator animatorHand;

    
    void Start()
    {
        animatorHand = GetComponent<Animator>();
        takeArea = GameObject.FindObjectOfType<AreaOfTaking>();
    }

    // Update is called once per frame
    void Update()
    {
        if (takeArea.ThingTakeAbble)
        {
            animatorHand.SetBool("takeOFF", false);
        }
        else
        {
            animatorHand.SetBool("takeOFF", true);
        }
    }
}
