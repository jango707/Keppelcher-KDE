using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_Manager : MonoBehaviour
{


    public Canvas StartSeit;
    public Canvas BeispillFro;
    public Canvas NummAginn;
    public Text Numm;

    public static string NummGeigner;

    public void OK()
    {
        NummAginn.gameObject.SetActive(false);
        StartSeit.gameObject.SetActive(true);

        NummGeigner = Numm.text;

        Debug.Log(NummGeigner);
    }
    
    private void Update()
    {
        if (BeispillFro.isActiveAndEnabled == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(1);
            }
        }

        if (StartSeit.isActiveAndEnabled == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                StartSeit.gameObject.SetActive(false);
                BeispillFro.gameObject.SetActive(true);
            }
        }
        
                
            
        
    }

}
        
        
	

