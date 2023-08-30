using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Camera MainCamera;
    public Camera SecondaryCamera;
    // Start is called before the first frame update
    void Start()
    {
        MainCamera.enabled = true;
        SecondaryCamera.enabled = false;
    }
    void OnMouseDown()
    {
        MainCamera.enabled = false;
        SecondaryCamera.enabled = true;
    }
}