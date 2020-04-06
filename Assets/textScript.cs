using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour {

    public string[] GielBox;

    public string[] GroBox;

    public Text[] GielTextBox;

    public Text[] GroTextBox;
   

    private void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            GielTextBox[i].text = GielBox[i];
            GroTextBox[i].text = GroBox[i];
        }
    }
}
