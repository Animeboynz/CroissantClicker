using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPerSecond : MonoBehaviour
{
    public double PerSecondCursors;
    public Text DisplayPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject mainCamera = GameObject.Find("Main Camera");
        PerSecond perSecond = mainCamera.GetComponent<PerSecond>();
        PerSecondCursors = perSecond.PerSecondCursors;
        DisplayPerSecond.text = PerSecondCursors + " Per Second";

    }
}
