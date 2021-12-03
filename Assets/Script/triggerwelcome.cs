using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerwelcome: MonoBehaviour
{
    // public bool isInDaZone;
    public GameObject the3DUI;
    public GameObject thetlighttest;
    public GameObject thesmoke;
    public GameObject thefood;
    public GameObject thevideo;
    public GameObject thesea;
    public GameObject thelondon;
    public GameObject thefoodpa;
    public GameObject thevideopa;
    public GameObject theseapa;
    public GameObject thelondonpa;

    public GameObject thefoodUI;
    public GameObject theseaUI;
    public GameObject thelondonUI;



    public GameObject thewelcomestuff;
    // public GameObject theSlogan;



    void Start()
    {
        // isInDaZone = false;
        
        the3DUI.SetActive(true);
        thetlighttest.SetActive(false);
        thesmoke.SetActive(false);
        thefood.SetActive(false);
        thesea.SetActive(false);
        thevideo.SetActive(false);
        thelondon.SetActive(false);
        thelondonpa.SetActive(false);
        theseapa.SetActive(false);
        thevideopa.SetActive(false);


        thefoodUI.SetActive(false);
        theseaUI.SetActive(false);
        thelondonUI.SetActive(false);





        // System.Threading.Thread.Sleep(2300);
        // the3DUI.SetActive(true);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            the3DUI.SetActive(false);
            thetlighttest.SetActive(true);
            // thecontent.SetActive(true);
            thewelcomestuff.SetActive(false);
            // theSlogan.SetActive(true);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            // the3DUI.SetActive(false);
        }

    }
}
