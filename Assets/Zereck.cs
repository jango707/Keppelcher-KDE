using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zereck : MonoBehaviour {
    public Canvas zereckFeld;
    public Canvas AllesRichteg;
	public void zereck()
    {
        zereckFeld.gameObject.SetActive(false);
        AllesRichteg.gameObject.SetActive(false);
        // UIElementDragger.countdownLass = true;
    }
}
