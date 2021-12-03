using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodTrigger : MonoBehaviour
{
    public GameObject thefood;
    public GameObject thefoodPa;
    public GameObject thelondonpa;
    public GameObject thefoodUI;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            thefood.SetActive(true);
            thefoodPa.SetActive(false);
            thelondonpa.SetActive(true);
            thefoodUI.SetActive(true);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            thefoodUI.SetActive(false);
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
