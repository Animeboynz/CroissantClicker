using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticsCameraSwap : MonoBehaviour
{
    public Camera MainCamera;
    public Camera CosmeticsCamera;
    // Start is called before the first frame update
    void Start()
    {
        MainCamera.enabled = true;
        CosmeticsCamera.enabled = false;
    }
    void OnMouseDown()
    {
        MainCamera.enabled = false;
        CosmeticsCamera.enabled = true;
    }
}
