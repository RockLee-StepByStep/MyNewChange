using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TornTvOn : MonoBehaviour
{
      public VideoPlayer VideoPlayer;
      public bool isPlayerStarted = false;

   

    public void TurnClipPlease()
    {
        if (isPlayerStarted)
        {
            VideoPlayer.Play();
            isPlayerStarted = !isPlayerStarted;
        }
        else if (isPlayerStarted != true)
        {
            VideoPlayer.Stop();
            isPlayerStarted = !isPlayerStarted;
        }
            
        
    }
}
