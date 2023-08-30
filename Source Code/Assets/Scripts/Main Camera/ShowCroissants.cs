using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCroissants : MonoBehaviour
{
    public Text Total;
    public double TotalBank;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This allows us to grab variables from the script on the Game Object Croissant
        GameObject mainCamera = GameObject.Find("Main Camera");
        PerSecond perSecond = mainCamera.GetComponent<PerSecond>();
        //This grabs the specific value of how many times the Croissant has been clicked
        TotalBank = perSecond.TotalBank;
        //
        Total.text = TotalBank + " Croissants";
    }
}
