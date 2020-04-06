using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/* Copyright (C) Xenfinity LLC - All Rights Reserved
 * Unauthorized copying of this file, via any medium is strictly prohibited
 * Proprietary and confidential
 * Written by Bilal Itani <bilalitani1@gmail.com>, June 2017
 */

public class UIElementDragger : MonoBehaviour
{

    public const string DRAGGABLE_TAG = "UIdraggable";

    private bool dragging = false;

    private Vector2 originalPosition;
    private Transform objectToDrag;
    private Image objectToDragImage;

    public Canvas Richteg;
    public Canvas Falsch;
    public Canvas AllesRichteg;
    public Canvas Zaitoof;
    public Button NextFro;


    public   AudioSource hannergrond;

    private bool _Richteg = false;

    private int richtegCount= 0;

    public float countdown = 20f;
    public static bool countdownLass = false;

    public Text TimerText;
    public Text GeignerNumm;

    public Text NummFro;
    public GameObject rietsSait;
    public GameObject lenksSait;

    public string Weieng_Nummer;

    public static int clickcount = 0;

    List<RaycastResult> hitObjects = new List<RaycastResult>();

    
    #region Monobehaviour API
    private void Start()
    {
        GeignerNumm.text = Start_Manager.NummGeigner;
        hannergrond.Stop();
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && clickcount ==0)
        {
            NummFro.gameObject.SetActive(true);
            clickcount= 1;
        }
        else if (Input.GetMouseButtonDown(0) && clickcount == 1)
        {
            rietsSait.gameObject.SetActive(true);
            clickcount= 2;
        }
        else if (Input.GetMouseButtonDown(0) && clickcount == 2)
        {
            lenksSait.gameObject.SetActive(true);
            clickcount= 3;
        }


        int countdownI = Mathf.RoundToInt(countdown);
        TimerText.text = countdownI.ToString();
        if (countdownLass)
        {
            
            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                ZaitoofFeld();
                
                countdown = 20f;
                countdownLass = false;
            }
            
        }
        if (Input.GetMouseButtonDown(0))
        {
            objectToDrag = GetDraggableTransformUnderMouse();

            if (objectToDrag != null)
            {
                dragging = true;

                objectToDrag.SetAsLastSibling();

                originalPosition = objectToDrag.position;
                objectToDragImage = objectToDrag.GetComponent<Image>();
                objectToDragImage.raycastTarget = false;
            }
        }

        if (dragging)
        {
            objectToDrag.position = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (objectToDrag != null)
            {
                var objectToReplace = GetDraggableTransformUnderMouse();

                if (objectToReplace != null)
                {
                    objectToDrag.position = objectToReplace.position;
                    objectToReplace.position = originalPosition;


                    
                    //display richteg 
                    
                        if (objectToDrag.name == "1" && objectToDrag.name != Weieng_Nummer) 
                        {
                            if (objectToDrag.localPosition.y > 149 && objectToDrag.localPosition.y < 151)
                            {
                            
                            _Richteg = true;
                            }
                            if(objectToDrag.localPosition.y < 149 || objectToDrag.localPosition.y > 151)
                             {
                            _Richteg = false;
                             }
                        }
                        

                    
                    

                    
                        if (objectToDrag.name == "2" && objectToDrag.name != Weieng_Nummer)
                         
                        {
                        if (objectToDrag.localPosition.y > 105 && objectToDrag.localPosition.y < 107)
                        {
                            _Richteg = true;
                        }
                        else if(objectToDrag.localPosition.y < 105 || objectToDrag.localPosition.y > 107)
                        {
                            _Richteg = false;
                        }

                        }
                       

                        
                        
                        if (objectToDrag.name == "3" && objectToDrag.name != Weieng_Nummer) 
                        {
                        if (objectToDrag.localPosition.y > 61 && objectToDrag.localPosition.y < 63)
                        {
                            _Richteg = true;
                        }
                        else if(objectToDrag.localPosition.y < 61 || objectToDrag.localPosition.y > 63)
                        {
                            _Richteg = false;
                        }
                        }
                       

                 

                   
                        if (objectToDrag.name == "4" && objectToDrag.name != Weieng_Nummer)
                        
                        {
                        if (objectToDrag.localPosition.y > 18 && objectToDrag.localPosition.y < 20)
                        {
                            _Richteg = true;
                        }
                        else if(objectToDrag.localPosition.y < 18 || objectToDrag.localPosition.y > 20)
                        {
                            _Richteg = false;
                        }
                        }




                    if (objectToDrag.name == "5" && objectToDrag.name != Weieng_Nummer)
                    {
                        if (objectToDrag.localPosition.y > -23 && objectToDrag.localPosition.y < -21)
                        {
                            _Richteg = true;
                        }

                        else if (objectToDrag.localPosition.y < -23 || objectToDrag.localPosition.y > -21)
                        {
                            _Richteg = false;
                        }
                    }


                    if (objectToDrag.name == "6" && objectToDrag.name != Weieng_Nummer)

                    {
                        if (objectToDrag.localPosition.y > -66 && objectToDrag.localPosition.y < -64)
                        {
                            _Richteg = true;
                        }

                       else if (objectToDrag.localPosition.y < -66 || objectToDrag.localPosition.y > -64)
                        {
                            _Richteg = false;
                        }
                    }


                    if (objectToDrag.name == "7" && objectToDrag.name != Weieng_Nummer)

                    {
                        if (objectToDrag.localPosition.y > -110 && objectToDrag.localPosition.y < -108)
                        {
                            _Richteg = true;
                        }

                        if (objectToDrag.localPosition.y < -110 || objectToDrag.localPosition.y > -108)
                        {
                            _Richteg = false;
                        }
                    }

                    
                        if (objectToDrag.name == "8" && objectToDrag.name != Weieng_Nummer)
                        {
                            _Richteg = false;


                        }
                    

                    if (objectToDrag.name == "9" && objectToDrag.name != Weieng_Nummer)

                    {
                        if (objectToDrag.localPosition.y > -194 && objectToDrag.localPosition.y < -192)
                        {
                            _Richteg = true;
                        }

                        if (objectToDrag.localPosition.y < -194 || objectToDrag.localPosition.y > -192)
                        {
                            _Richteg = false;
                        }

                    }

                    if ( objectToDrag.name == Weieng_Nummer)
                    {
                        if (objectToDrag.localPosition.y > -152 && objectToDrag.localPosition.y < -150)
                        {
                            _Richteg = true;
                        }

                        if (objectToDrag.localPosition.y < -152 || objectToDrag.localPosition.y > -150)
                        {
                            _Richteg = false;
                        }
                    }

                }
                else
                {
                    objectToDrag.position = originalPosition;
                }

                objectToDragImage.raycastTarget = true;
                objectToDrag = null;
            }

            dragging = false;
        }
    }
    public int secondstoShow = 2;

    private void ZaitoofFeld()
    {
       
        Zaitoof.gameObject.SetActive(true);
        
        countdownLass = false;
       
    }
    private void FalschFeld()
    {
        hannergrond.Stop();
        NextFro.gameObject.SetActive(true); 
        Falsch.gameObject.SetActive(true);
        StartCoroutine(RemoveAfterSeconds(secondstoShow, Falsch));

    }
    private void RichtegFeld()
    {
        hannergrond.Stop();
        Richteg.gameObject.SetActive(true);
        NextFro.gameObject.SetActive(false   );
        StartCoroutine(RemoveAfterSeconds(secondstoShow, Richteg));
        richtegCount++;
        if(richtegCount >= 8)
        {
            AllesRichteg.gameObject.SetActive(true);
        }
        
    }
    IEnumerator RemoveAfterSeconds(int seconds, Canvas Feld)
    {
        yield return new WaitForSeconds(seconds);
        countdown = 20f;
        
        Feld.gameObject.SetActive(false);
        if (_Richteg == false)
        {
            countdownLass = false;
        }
        else
        {
            //countdownLass = true;
            //hannergrond.Play();
        }
    }

    
    private GameObject GetObjectUnderMouse()
    {
        var pointer = new PointerEventData(EventSystem.current);

        pointer.position = Input.mousePosition;

        EventSystem.current.RaycastAll(pointer, hitObjects);

        if (hitObjects.Count <= 0) return null;

        return hitObjects.First().gameObject;
    }

    private Transform GetDraggableTransformUnderMouse()
    {
        var clickedObject = GetObjectUnderMouse();

        // get top level object hit
        if (clickedObject != null && clickedObject.tag == DRAGGABLE_TAG)
        {
            return clickedObject.transform;
        }

        return null;
    }

    #endregion

    public void BestätegungsKneppschen()
    {
       
        if (_Richteg)
        {
            RichtegFeld();
            countdownLass = false;
        }
        if (!_Richteg)
        {
            FalschFeld();
            countdownLass = false;
        }


    }
}
