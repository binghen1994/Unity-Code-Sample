using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointer : MonoBehaviour
{
    public GameObject pointer_object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {


            pointer_object.transform.position = hit.point;



            }
    }
}
