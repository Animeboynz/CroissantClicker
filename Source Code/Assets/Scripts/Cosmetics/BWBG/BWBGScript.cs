using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BWBGScript : MonoBehaviour
{
    //public int bgcolour2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        GameObject background = GameObject.Find("Background");
        BackgroundScript backgroundscript = background.GetComponent<BackgroundScript>();
        backgroundscript.bgcolour = 3;
    
    }
}