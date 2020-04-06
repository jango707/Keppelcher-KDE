using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopZait : MonoBehaviour {

	public void Pause()
    {
        UIElementDragger.countdownLass = false;
        Camera.main.GetComponent<AudioSource>().Pause();


    }

    public void Play()
    {
        UIElementDragger.countdownLass = true;
        Camera.main.GetComponent<AudioSource>().Play();
    }
}
