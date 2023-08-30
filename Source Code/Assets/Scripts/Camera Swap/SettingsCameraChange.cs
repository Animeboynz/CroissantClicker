using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsCameraChange : MonoBehaviour
{
    public Camera MainCamera;
    public Camera SettingsCamera;
    // Start is called before the first frame update
    void Start()
    {
        MainCamera.enabled = true;
        SettingsCamera.enabled = false;
    }
    void OnMouseDown()
    {
        MainCamera.enabled = false;
        SettingsCamera.enabled = true;
    }
}
