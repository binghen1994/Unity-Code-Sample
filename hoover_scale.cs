using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoover_scale : MonoBehaviour
{

    public float scale;
    Vector3 scale_init;
    // Start is called before the first frame update
    void Start()
    {
        scale_init = gameObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        gameObject.transform.localScale = scale_init * scale;
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        //Debug.Log("Mouse is no longer on GameObject.");
        gameObject.transform.localScale = scale_init;
    }
}
