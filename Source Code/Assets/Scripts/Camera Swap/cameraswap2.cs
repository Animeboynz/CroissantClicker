using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraswap2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera MainCamera;
    public Camera SecondaryCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        MainCamera.enabled = true;
        SecondaryCamera.enabled = false;
    }
}
