using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punkten : MonoBehaviour {
    public Sprite Blo;
    public Sprite Roud;
    public Sprite Weiss;

    public GameObject BloGO1;
    public GameObject BloGO2;
    public GameObject BloGO3;
    public GameObject BloGO4;
    public GameObject BloGO5;

    public GameObject RoudGO1;
    public GameObject RoudGO2;
    public GameObject RoudGO3;
    public GameObject RoudGO4;
    public GameObject RoudGO5;

    public static bool asgeclicked1 ;
    public static bool asgeclicked2 ;
    public static bool asgeclicked3 ;
    public static bool asgeclicked4 ;
    public static bool asgeclicked5 ;

    public static bool Rasgeclicked1 ;
    public static bool Rasgeclicked2 ;
    public static bool Rasgeclicked3 ;
    public static bool Rasgeclicked4 ;
    public static bool Rasgeclicked5 ;



    public void Start()
    {
        
        if (asgeclicked1 == true)
        {
            BloGO1.GetComponent<Image>().sprite = Blo;
            
        }
        if (asgeclicked2 == true)
        {
            BloGO2.GetComponent<Image>().sprite = Blo;

        }
        if (asgeclicked3 == true)
        {
            BloGO3.GetComponent<Image>().sprite = Blo;

        }
        if (asgeclicked4 == true)
        {
            BloGO4.GetComponent<Image>().sprite = Blo;

        }
        if (asgeclicked5 == true)
        {
            BloGO5.GetComponent<Image>().sprite = Blo;

        }
        if (Rasgeclicked1 == true)
        {
            RoudGO1.GetComponent<Image>().sprite = Roud;

        }
        if (Rasgeclicked2 == true)
        {
            RoudGO2.GetComponent<Image>().sprite = Roud;

        }
        if (Rasgeclicked3 == true)
        {
            RoudGO3.GetComponent<Image>().sprite = Roud;

        }
        if (Rasgeclicked4 == true)
        {
            RoudGO4.GetComponent<Image>().sprite = Roud;

        }
        if (Rasgeclicked5 == true)
        {
            RoudGO5.GetComponent<Image>().sprite = Roud;

        }
    }
    public void BloPunkt1()
    {
        if (asgeclicked1 == false)
        {
            BloGO1.GetComponent<Image>().sprite = Blo;
            asgeclicked1 = true;
        }
        else if(asgeclicked1)
        {
            BloGO1.GetComponent<Image>().sprite = Weiss;
            asgeclicked1 = false;
        }
        

    }

    public void BloPunkt2()
    {
        if (asgeclicked2 == false)
        {
            BloGO2.GetComponent<Image>().sprite = Blo;
            asgeclicked2 = true;
        }
        else if (asgeclicked2)
        {
            BloGO2.GetComponent<Image>().sprite = Weiss;
            asgeclicked2 = false;
        }


    }
    public void BloPunkt3()
    {
        if (asgeclicked3 == false)
        {
            BloGO3.GetComponent<Image>().sprite = Blo;
            asgeclicked3 = true;
        }
        else if (asgeclicked3)
        {
            BloGO3.GetComponent<Image>().sprite = Weiss;
            asgeclicked3 = false;
        }


    }
    public void BloPunkt4()
    {
        if (asgeclicked4 == false)
        {
            BloGO4.GetComponent<Image>().sprite = Blo;
            asgeclicked4 = true;
        }
        else if (asgeclicked4)
        {
            BloGO4.GetComponent<Image>().sprite = Weiss;
            asgeclicked4 = false;
        }


    }
    public void BloPunkt5()
    {
        if (asgeclicked5 == false)
        {
            BloGO5.GetComponent<Image>().sprite = Blo;
            asgeclicked5 = true;
        }
        else if (asgeclicked5)
        {
            BloGO5.GetComponent<Image>().sprite = Weiss;
            asgeclicked5 = false;
        }


    }
    public void RoudPunkt1()
    {
        if (Rasgeclicked1 == false)
        {
            RoudGO1.GetComponent<Image>().sprite = Roud;
            Rasgeclicked1 = true;
        }
        else if (Rasgeclicked1)
        {
            RoudGO1.GetComponent<Image>().sprite = Weiss;
            Rasgeclicked1 = false;
        }


    }
    public void RoudPunkt2()
    {
        if (Rasgeclicked2 == false)
        {
            RoudGO2.GetComponent<Image>().sprite = Roud;
            Rasgeclicked2 = true;
        }
        else if (Rasgeclicked2)
        {
            RoudGO2.GetComponent<Image>().sprite = Weiss;
            Rasgeclicked2 = false;
        }


    }
    public void RoudPunkt3()
    {
        if (Rasgeclicked3 == false)
        {
            RoudGO3.GetComponent<Image>().sprite = Roud;
            Rasgeclicked3 = true;
        }
        else if (Rasgeclicked3)
        {
            RoudGO3.GetComponent<Image>().sprite = Weiss;
            Rasgeclicked3 = false;
        }


    }
    public void RoudPunkt4()
    {
        if (Rasgeclicked4 == false)
        {
            RoudGO4.GetComponent<Image>().sprite = Roud;
            Rasgeclicked4 = true;
        }
        else if (Rasgeclicked4)
        {
            RoudGO4.GetComponent<Image>().sprite = Weiss;
            Rasgeclicked4 = false;
        }


    }
    public void RoudPunkt5()
    {
        if (Rasgeclicked5 == false)
        {
            RoudGO5.GetComponent<Image>().sprite = Roud;
            Rasgeclicked5 = true;
        }
        else if (Rasgeclicked5)
        {
            RoudGO5.GetComponent<Image>().sprite = Weiss;
            Rasgeclicked5= false;
        }


    }


}
