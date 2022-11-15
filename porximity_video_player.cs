using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class porximity_video_player : MonoBehaviour
{
    VideoPlayer videoPlayer;
    public GameObject player;
    public float min_distance=1f;

    float distance;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if(distance<min_distance)

        {
            videoPlayer.Play();

        }

        else
        {

            videoPlayer.Stop();
        }

        Debug.Log(distance);
            
    }

  
}
