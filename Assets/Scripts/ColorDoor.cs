////////////////////////////////////////////
////                                    ////
////   Autor: Jonas Fischer             ////
////                                    ////
////////////////////////////////////////////

using UnityEngine;
using System.Collections;

public class ColorDoor : MonoBehaviour
{
    public AudioSource Open;
    public AudioSource Correct;
	
    private bool doorIsOpen = false;

    private void OpenDoor()
    {
        Correct.Play();
        this.GetComponent<Animation>().Play();
        doorIsOpen = true;
        Open.Play(); 
    }

	void Update () 
    {
		//Überprüft ob alle Farben richtig sind und öffnet dann die Tür
        if (GameObject.FindGameObjectWithTag("CCPink").GetComponent<ColorCube>().Match == true &&
            GameObject.FindGameObjectWithTag("CCTurqouis").GetComponent<ColorCube>().Match == true &&
            GameObject.FindGameObjectWithTag("CCOrange").GetComponent<ColorCube>().Match == true)
        {
            if (!doorIsOpen)
            {
                OpenDoor();
            }
        }
	
	}
}
