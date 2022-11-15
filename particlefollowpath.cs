using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlefollowpath : MonoBehaviour
{
    // Start is called before the first frame update
    public string pathName;
    public float time;
    void Start()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath(pathName), "easetype", iTween.EaseType.easeInOutSine, "time", time));
    }

}