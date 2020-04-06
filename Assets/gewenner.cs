using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gewenner : MonoBehaviour {


    public Canvas FerdegCanvas;

    public Canvas George;
    public Canvas Geigner;

    public Text GeignerNumm;

    private void Start()
    {
        
    }

    public void RoudGewonn()
    {
        FerdegCanvas.gameObject.SetActive(false);
        George.gameObject.SetActive(true);
    }

    public void BloGewonn()
    {
        FerdegCanvas.gameObject.SetActive(false);
        George.gameObject.SetActive(true);
    }
}
