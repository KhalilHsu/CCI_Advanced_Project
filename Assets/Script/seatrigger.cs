using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seatrigger : MonoBehaviour
{
    public GameObject thesea;
    public GameObject theseapa;
    public GameObject thevideopa;
    public GameObject theseaUI;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            thesea.SetActive(true);
            theseapa.SetActive(false);
            thevideopa.SetActive(true);
            theseaUI.SetActive(true);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            theseaUI.SetActive(false);

            // the3DUI.SetActive(false);
        }
    }
}