using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_over_pop_up : MonoBehaviour
{

   // public Material mat_initial;
   // public Material mat_outline;
    //public GameObject Peps;

    public GameObject options_panel;
    
    // Start is called before the first frame update
    void Start()
    {
       //Peps.GetComponent<Renderer>().material = mat_initial;
        options_panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
       // Debug.Log("Mouse is over GameObject.");
        //Peps.GetComponent<Renderer>().material = mat_outline;
        options_panel.SetActive(true);
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        //Debug.Log("Mouse is no longer on GameObject.");
        //Peps.GetComponent<Renderer>().material = mat_initial;
        options_panel.SetActive(false);
    }
}
