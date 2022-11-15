using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_scene_on_click : MonoBehaviour
{

    public string scene_to_load;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {


                Debug.Log("Cube Over");
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Intro_Cube"))
                {
                    Debug.Log("Cube Enter clicked");
                    SceneManager.LoadScene(scene_to_load);

                }

            }
        }
    }

    
}
