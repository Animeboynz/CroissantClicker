using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBGScript : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        GameObject background = GameObject.Find("Background");
        BackgroundScript backgroundscript = background.GetComponent<BackgroundScript>();
        backgroundscript.bgcolour = 0;
    
    }
}