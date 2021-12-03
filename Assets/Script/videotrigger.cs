using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videotrigger : MonoBehaviour
{
    public GameObject thevideo;
    //public GameObject theseapa;
    public GameObject thevideopa;
    public GameObject alltrigger;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //thevideo.SetActive(false);

            thevideo.SetActive(true);
            //theseapa.SetActive(false);
            thevideopa.SetActive(false);
            alltrigger.SetActive(false);


        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            // the3DUI.SetActive(false);
        }

    }












    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
