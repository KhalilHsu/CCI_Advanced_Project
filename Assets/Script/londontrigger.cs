using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class londontrigger : MonoBehaviour
{
    public GameObject thelondon;
    public GameObject theseapa;
    public GameObject thelondonpa;
    public GameObject thelondonsmoke;
    public GameObject thelondonUI;




    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            thelondon.SetActive(true);
            theseapa.SetActive(true);
            thelondonpa.SetActive(false);
            thelondonsmoke.SetActive(true);
            thelondonUI.SetActive(true);


        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            thelondonUI.SetActive(false);

            // the3DUI.SetActive(false);
        }
    }

}
