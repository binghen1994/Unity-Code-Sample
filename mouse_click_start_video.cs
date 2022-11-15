using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class mouse_click_start_video : MonoBehaviour
{
    VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
        videoPlayer = gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();
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
                if (hit.collider.gameObject == gameObject )
                {
                    Debug.Log("Cube Enter clicked");
                    if(videoPlayer.isPlaying)
                    { videoPlayer.Stop(); }

                    else
                    {

                        videoPlayer.Play();

                    }
                    

                }

            }
        }
    }
}
