using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayUsingControls : MonoBehaviour
{
    public AudioSource source;
    private bool hasPlayed = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P) && !hasPlayed)
        {
            source.Play();
            hasPlayed = true;
        }
    }
}
